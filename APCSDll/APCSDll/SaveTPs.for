	subroutine SaveTPs(nTP,nPtTP,xTP,DMITP,xOffTP,fctCrct,Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: SaveTPs
	 !DEC$ ATTRIBUTES ALIAS:'SaveTPs' :: SaveTPs
	 !DEC$ ATTRIBUTES Reference :: 
     $	nTP,nPtTP,xTP,DMITP,xOffTP,fctCrct,Filename
     
      integer nTP,nPtTP(100),lName,iTP,iPt
      
      real xTP(2,5000,100),DMITP(100),xOffTP(100),fctCrct(100)
      
      CHARACTER*(lName) Filename
      
      open (8567, file=Filename)
      
      write (8567,*) nTP+1
      
      do iTP=1,nTP+1
        write (8567,'(I8,3F8.3)') nPtTP(iTP)+1,
     $   DMITP(iTP),xOffTP(iTP),fctCrct(iTP)
        do iPt=1,nPtTP(iTP)+1
            write (8567,'(2F8.3)') xTP(1,iPt,iTP), xTP(2,iPt,iTP)
        end do
      end do
      
      close (8567)
      end subroutine SaveTPs
      
