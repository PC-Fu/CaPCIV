	subroutine ReadTRP(nTRP,nPtTRP,xTRP,yTRP,
     $	DMITRP,Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadTRP
	 !DEC$ ATTRIBUTES ALIAS:'ReadTRP' :: ReadTRP
	 !DEC$ ATTRIBUTES Reference :: nTRP,nPtTRP,xTRP,yTRP
     $	DMITRP,Filename
     
      integer nTRP,nPtTRP(10000),lName,iTRP,iPt,i,nCol,iNC,iCol2
      
      real xTRP(1000),yTRP(1000,10000),DMITRP(10000),dmi0
      
      CHARACTER*(lName) Filename
 
      real realVal(1000),a,b 
      
      character *15 chaVal(1000)
      character *10000 cLine
      
      open (100, file=Filename)
      open (101,file="Intermediate.dat")
      
      read (100,*) (chaVal(i),i=1,15)
     
      rewind (100)
      read (100,'(A10000)') cLine
      ! The files supplied by Fugro have different number of columns.  Sometimes "newchain" is the 9th column, sometimes 11th.
      ! Need to check where "newchain" is
      
      iNC=1
      do while (chaVal(iNC)(1:8).ne."newchain")
        iNC=iNC+1
      end do
      
      iCol2=1
      do while (chaVal(iCol2)(1:8).ne."column2")
        iCol2=iCol2+1
      end do
      
      
      nTRP=0
      nCol=0
      
      do i=1,LEN_TRIM(cLine)
        if (cLine(i:i).eq.",") then
            nCol=nCol+1
        end if
      end do
      
      nCol=nCol+2-iCol2
      
      do while (.not.EOF(100))
        read (100,*) (chaVal(i),i=1,nCol+iCol2-1)
     
        write (101,'(1000(A8,","))') chaVal(iNC),
     $   (chaVal(i),i=iCol2,nCol+iCol2-1)
      
        nTRP=nTRP+1
      end do
      close (100)
      
      
      rewind (101)
      
      do i=1,1000
        xTRP(i)=(i-1)*0.0254
      end do
      
      do iTRP=1,nTRP
        read (101,*) dmiTRP(iTRP),(yTRP(i,iTRP),i=1,nCol)
      end do
      
      close (101)
      
      
      do iTRP=1,nTRP
        iPt=1
        nPtTRP(iTRP)=nCol
        
        ! to get rid of all the -1 in the beginning
        do while (yTRP(iPt,iTRP).eq.-1.0) 
            nPtTRP(iTRP)=nPtTRP(iTRP)-1
            yTRP(iPt:iPt+nPtTRP(iTRP)-1,iTRP)=
     $       yTRP(iPt+1:iPt+nPtTRP(iTRP),iTRP)
        end do
        
        
        ! to get rid of all the -1 and 0 in the end
        
        do while (((yTRP(nPtTRP(iTRP),iTRP).eq.-1.0).or.
     $   (yTRP(nPtTRP(iTRP),iTRP).eq.0.0)).and.(nPtTRP(iTRP).gt.1))
            nPtTRP(iTRP)=nPtTRP(iTRP)-1
        end do
        
        do iPt=2,nPtTRP(iTRP)-1
            if (yTRP(iPt,iTRP).eq.-1.0) then
                i=iPt+1
                do while (yTRP(i,iTRP).eq.-1.0) 
                    i=i+1
                end do
                yTRP(iPt,iTRP)=yTRP(iPt-1,iTRP)
     $           +(yTRP(i,iTRP)-yTRP(iPt-1,iTRP))/(i-iPt+1)
            end if
        end do
        
        
        
        
        call Regression(nPtTRP(iTRP),xTRP(1:nPtTRP(iTRP)),
     $   yTRP(1:nPtTRP(iTRP),iTRP),a,b)

        do iPt=1,nPtTRP(iTRP)
            yTRP(iPt,iTRP)=yTRP(iPt,iTRP)-a*xTRP(iPt)-b
        
        end do
        
c        write (102,'(I8,", ",10000(F11.6,", "))') nPtTRP(iTRP),
c     $   (dmiTRP(iTRP)-dmiTRP(1))*1609,
c     $   (yTRP(iPt,iTRP),iPt=1,nPtTRP(iTRP))
        
    
      end do
      
      yTRP=yTRP/1000
      dmi0=dmiTRP(1)
      dmiTRP=abs(DMITRP-dmi0)*1609.3

      
      end subroutine
      
