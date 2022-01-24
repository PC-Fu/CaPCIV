	subroutine RutDep(nTP,nPtTP,xPtTP,proFlt,iPtBound,Para,iPtHump,iPtBot,
     $ 	RD,xRod,zRod)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: RutDep
	 !DEC$ ATTRIBUTES ALIAS:'RutDep' :: RutDep
	 !DEC$ ATTRIBUTES Reference :: 
     $	nTP,nPtTP,xPtTP,proFlt,iPtBound,Para,iPtHump,iPtBot,
     $ 	RD,xRod,zRod
     
      integer nTP,nPtTP(1000),iPt,iPtBound(7,1000),iPtHump(2,2,1000),
     $ iPtBot(2,1000),iTP,i
     
      real xPtTP(10000,1000),proFlt(10000,1000),Para(4),xBot,
     $ RD(2,1000),xRod(6,1000),zRod(6,1000)
     
      real xPt(10000),zPt(10000)
      
      ! Para() are spaceholder for parameters.  
      ! Para(1) is the tolerance for ending iterations
      ! Para(2) is the distance from lane centerline to wheelpath centerline, Typically use 0.9 (legacy, not used)
      ! Para(3) is the number of iterations allowed
      
      ! xRod, zRod are the coordinates for six reference points.  1,2,3,4 are the ends of the rods; 5,6 are the projections on the rods
      
      real dist(10000),q,PtLineDist,
     $ xRef(2,2),zRef(2,2),distHump(2),tempLHump,tempRHump,r
      
      integer flagEnd,iStart(2),iEnd(2),iWP(2),iIter
      
      ! Search the point corresponding to the center line
      
      !preRelaX=0
      !xWP(1)=xCT-Para(2)
      !xWP(2)=xCT+Para(2)
      !minCT=100000
      !minLWP=100000
      !minRWP=100000
            
      do iTP=1,nTP
            
          xPt=xPtTP(:,iTP)
          zPt=proFlt(:,iTP)
          
          
          xRef(1,1)=xPt(iPtBound(1,iTP))
          xRef(1,2)=xPt(iPtBound(3,iTP))
          zRef(1,1)=1.0
          xRef(2,1)=xPt(iPtBound(5,iTP))
          xRef(2,2)=xPt(iPtBound(6,iTP))
          zRef(2,1)=1.0
          iStart(1)=iPtBound(1,iTP)
          iStart(2)=iPtBound(5,iTP)
          iEnd(1)=iPtBound(3,iTP)
          iEnd(2)=iPtBound(7,iTP)
          iWP(1)=iPtBound(2,iTP)
          iWP(2)=iPtBound(6,iTP)
          
          do i=1,2
            q=0
            iIter=0
            flagEnd=0
            do while (flagEnd.eq.0)
            
                zRef(i,2)=zRef(i,1)+(xRef(i,2)-xRef(i,1))*tan(q)
            
                do iPt=iStart(i),iEnd(i)
                    dist(iPt)=PtLineDist(xPt(iPt),zPt(iPt),
     $             xRef(i,1),zRef(i,1),xRef(i,2),zRef(i,2))
                end do
            
                tempLHump=1000000
                tempRHump=1000000
                
                do iPt=iStart(i),iWP(i)
                    if (dist(iPt).lt.tempLHump) then
                        tempLHump=dist(iPt)
                        iPtHump(i,1,iTP)=iPt
                    end if            
                end do
                do iPt=iWP(i),iEnd(i)
                    if (dist(iPt).lt.tempRHump) then
                        tempRHump=dist(iPt)
                        iPtHump(i,2,iTP)=iPt
                    end if            
                end do
                
                if (abs(tempLHump-tempRHump).le.Para(1)) then
                    flagEnd=1
                else
                    q=q-(tempRHump-tempLHump)/
     $                (xPt(iPtHump(i,2,iTP))-xPt(iPtHump(i,1,iTP)))
                    iIter=iIter+1
                    
                    if (iIter.gt.Para(3)) then
                        flagEnd=1
                    end if
                end if
                
            end do
                
                RD(i,iTP)=-1000000

                do iPt=iPtHump(i,1,iTP), iPtHump(i,2,iTP)
                   dist(iPt)=PtLineDist(xPt(iPt),zPt(iPt),
     $              xPt(iPtHump(i,1,iTP)),zPt(iPtHump(i,1,iTP)),
     $               xPt(iPtHump(i,2,iTP)),zPt(iPtHump(i,2,iTP)))
                    if (dist(iPt).gt.RD(i,iTP)) then
                        RD(i,iTP)=dist(iPt)
                        iPtBot(i,iTP)=iPt
                    end if            
                end do

          end do
            
          ! Calculate the locations of the reference points
          
          xRod(1,iTP)=xPt(iPtBound(1,iTP))
          xRod(2,iTP)=xPt(iPtBound(3,iTP))
          xRod(3,iTP)=xPt(iPtBound(5,iTP))
          xRod(4,iTP)=xPt(iPtBound(7,iTP))
          
          zRod(1,iTP)=(xRod(1,iTP)-xPt(iPtHump(1,1,iTP)))/
     $      (xPt(iPtHump(1,2,iTP))-xPt(iPtHump(1,1,iTP)))*
     $      (zPt(iPtHump(1,2,iTP))-zPt(iPtHump(1,1,iTP)))+
     $      zPt(iPtHump(1,1,iTP))
          
          zRod(2,iTP)=(xRod(2,iTP)-xPt(iPtHump(1,1,iTP)))/
     $      (xPt(iPtHump(1,2,iTP))-xPt(iPtHump(1,1,iTP)))*
     $      (zPt(iPtHump(1,2,iTP))-zPt(iPtHump(1,1,iTP)))+
     $      zPt(iPtHump(1,1,iTP))
          
          zRod(3,iTP)=(xRod(3,iTP)-xPt(iPtHump(2,1,iTP)))/
     $      (xPt(iPtHump(2,2,iTP))-xPt(iPtHump(2,1,iTP)))*
     $      (zPt(iPtHump(2,2,iTP))-zPt(iPtHump(2,1,iTP)))+
     $      zPt(iPtHump(2,1,iTP))
          
          zRod(4,iTP)=(xRod(4,iTP)-xPt(iPtHump(2,1,iTP)))/
     $      (xPt(iPtHump(2,2,iTP))-xPt(iPtHump(2,1,iTP)))*
     $      (zPt(iPtHump(2,2,iTP))-zPt(iPtHump(2,1,iTP)))+
     $      zPt(iPtHump(2,1,iTP))
          
          r=((zPt(iPtHump(1,2,iTP))-zPt(iPtBot(1,iTP)))*
     $      (zPt(iPtHump(1,2,iTP))-zPt(iPtHump(1,1,iTP)))-
     $      (xPt(iPtHump(1,2,iTP))-xPt(iPtBot(1,iTP)))*
     $      (xPt(iPtHump(1,1,iTP))-xPt(iPtHump(1,2,iTP))))/
     $      ((xPt(iPtHump(1,1,iTP))-xPt(iPtHump(1,2,iTP)))**2+
     $      (zPt(iPtHump(1,1,iTP))-zPt(iPtHump(1,2,iTP)))**2)
          
          xRod(5,iTP)=xPt(iPtHump(1,2,iTP))+
     $       r*(xPt(iPtHump(1,1,iTP))-xPt(iPtHump(1,2,iTP)))
          zRod(5,iTP)=zPt(iPtHump(1,2,iTP))+
     $       r*(zPt(iPtHump(1,1,iTP))-zPt(iPtHump(1,2,iTP)))
          
          r=((zPt(iPtHump(2,2,iTP))-zPt(iPtBot(2,iTP)))*
     $      (zPt(iPtHump(2,2,iTP))-zPt(iPtHump(2,1,iTP)))-
     $      (xPt(iPtHump(2,2,iTP))-xPt(iPtBot(2,iTP)))*
     $      (xPt(iPtHump(2,1,iTP))-xPt(iPtHump(2,2,iTP))))/
     $      ((xPt(iPtHump(2,1,iTP))-xPt(iPtHump(2,2,iTP)))**2+
     $      (zPt(iPtHump(2,1,iTP))-zPt(iPtHump(2,2,iTP)))**2)
          
          xRod(6,iTP)=xPt(iPtHump(2,2,iTP))+
     $       r*(xPt(iPtHump(2,1,iTP))-xPt(iPtHump(2,2,iTP)))
          zRod(6,iTP)=zPt(iPtHump(2,2,iTP))+
     $       r*(zPt(iPtHump(2,1,iTP))-zPt(iPtHump(2,2,iTP)))
          
      end do ! iTP    

      end subroutine
      
      
      Real Function PtLineDist(x0,y0,x1,y1,x2,y2)
      implicit none
      real x0,y0,x1,y1,x2,y2
      PtLineDist=abs((x2-x1)*(y1-y0)-(x1-x0)*(y2-y1))
     $          /sqrt((x2-x1)**2+(y2-y1)**2)
      
      return
      end function 
      
	
