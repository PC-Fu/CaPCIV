	subroutine FilterTP(nTP,nPtTP,xPtTP,proTRaw,proFlt,iPtBound)

      ! Smooth the profile by taking the upper envelope and also decide the boundaries for the left and right wheelpaths
      
	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: FilterTP
	 !DEC$ ATTRIBUTES ALIAS:'FilterTP':: FilterTP
	 !DEC$ ATTRIBUTES Reference :: 
     $  nTP,nPtTP,xPtTP,proTRaw,proFlt,iPtBound
     
      integer nTP,nPtTP(1000),iTP,iPt,iPtBound(7,1000)
      
      real xPtTP(10000,1000),proTRaw(10000,1000),proFlt(10000,1000),
     $      xIntv,maxTemp,i,xTemp(3400)
     
      integer nPtBrg, iBrg,iLeft,iRight
      
      real lBrg,a,b
      
      
      double precision y1,y2
      real ca,cb

      
      ! iPtBound(4) is the point id of the center line; iPtBound(1) and (3) are the boundaries for evaluating the LWP rut, iPtBound(2) is on the LWP line. 
      
      proFlt=proTRaw
      xIntv=(xPtTP(nPtTP(1),1)-xPtTP(1,1))/(nPtTP(1)-1) 
       ! xIntv is negative in this case becase the laser scanner ran from right to left
      lBrg=0.05      
      nPtBrg=abs(lBrg/xIntv)
      
      
      do iPt=1,3400
       
       xTemp(iPt)=iPt-1.0
      
      end do
      
      do iTP=1,nTP


        ! To subtract the linear trend, first find the centroids of the first 399 points and the last 399 points of the profile
        ! Then obtain the linear trend line (not the best fit line) by connecting these two centroids 

        y1=0
        y2=0
        do iPt=1,399
            y1=y1+proTRaw(iPt,iTP)
            y2=y2+proTRaw(nPtTP(iTP)+1-iPt,iTP)
        end do
        
        y1=y1/399.0
        y2=y2/399.0
        
        
        ca=(y2-y1)/
     $   (xPtTP(nPtTP(iTP)-199,iTP)-xPtTP(200,iTP))
     

        cb=(xPtTP(nPtTP(iTP)-199,iTP)*y1-
     $     xPtTP(200,iTP)*y2)/
     $   (xPtTP(nPtTP(iTP)-199,iTP)-xPtTP(200,iTP))
     
     

      ! Subtracting the special linear trend line.        
        proTRaw(1:nPtTP(iTP),iTP)=proTRaw(1:nPtTP(iTP),iTP)
     $   -xPtTP(1:nPtTP(iTP),iTP)*ca-cb
      
      
      ! Bending correction
        do iPt=1,nPtTP(iTP)
            proTRaw(iPt,iTP)=proTRaw(iPt,iTP)-(1.1576e-10*xTemp(iPt)**3
     $      -1.5184e-6*xTemp(iPt)**2+3.9564e-3**xTemp(iPt)-2.0129)*0.001
            
        end do
     
        proFlt(1:nPtTP(iTP),iTP)=proTRaw(1:nPtTP(iTP),iTP)
        
        do iPt=1,nPtTP(iTP)-nPtBrg
            a=(proTRaw(iPt+nPtBrg,iTP)-proTRaw(iPt,iTP))/
     $      (xPtTP(iPt+nPtBrg,iTP)-xPtTP(iPt,iTP))
     
            b=proTRaw(iPt,iTP)-xPtTP(iPt,iTP)*a
        
            do iBrg=0,nPtBrg
                proFlt(iPt+iBrg,iTP)=
     $           max(xPtTP(iPt+iBrg,iTP)*a+b,proFlt(iPt+iBrg,iTP))
        
            end do
        end do
     
      end do
      
      
      
      do iTP=1,nTP
      
        if (maxval(proFlt(1:nPtTP(iTP),iTP)).le.0.015) then    ! Missing the box at the center line
            maxTemp=-100000
            do i=abs(1.4/xIntv),nPtTP(iTP)-abs(1.4/xIntv)
                if (proFlt(i,iTP).gt.maxTemp) then
                    maxTemp=proFlt(i,iTP)
                    iPtBound(4,iTP)=i
               
                end if
            end do
            
        else
        
            iLeft=abs(1./xIntv)
            iRight=nPtTP(iTP)-abs(1./xIntv)
            
            do while ((proFlt(iLeft,iTP).lt.0.015)
     $                 .and.(iLeft.lt.nPtTP(iTP)))
                iLeft=iLeft+1
            end do
            do while ((proFlt(iRight,iTP).lt.0.015)
     $                 .and.(iRight.gt.1))       
                iRight=iRight-1
            end do
            
            iPtBound(4,iTP)=(iLeft+iRight)/2
        end if
        
        iPtBound(3,iTP)=iPtBound(4,iTP)-0.1/abs(xIntv)
        iPtBound(2,iTP)=iPtBound(4,iTP)-0.9/abs(xIntv)
        iPtBound(1,iTP)=max(int(iPtBound(4,iTP)-1.5/abs(xIntv)),1)
        iPtBound(5,iTP)=iPtBound(4,iTP)+0.1/abs(xIntv)
        iPtBound(6,iTP)=iPtBound(4,iTP)+0.9/abs(xIntv)
        iPtBound(7,iTP)=min(int(iPtBound(4,iTP)+1.5/abs(xIntv)),
     $   nPtTP(iTP))
      
      end do
      
      
      
      open (374,File="AllProfile.dat")
      write (374,'(1000(A12,", "))') 
     $ (("x","Pro-Raw(mm)","Pro-Flt(mm)"),iTP=1,nTP)
      do iPt=1,nPtTP(1)
        write (374,'(1000(F12.5,", "))') ((xPtTP(iPt,iTP), 
     $   proTRaw(iPt,iTP)*1000,proFlt(iPt,iTP)*1000),
     $   iTP=1,nTP)
      end do
      close (374)
      
      
      ! For paper writing, export profile data
      
      do iTP=1,nTP
        write (3910, *) "Profile",iTP
        do iPt=1, nPtTP(iTP)
         write (3910,'(100F13.5)') xPtTP(iPt,iTP),
     $    proTRaw(iPt,iTP),proFlt(iPt,iTP)
        end do
      
      end do
      
      end subroutine




      