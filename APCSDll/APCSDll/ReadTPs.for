	subroutine ReadTPs(nTP,nPtTP,xTP,
     $	DMITP,xOffTP,fctCrct,Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadTPs
	 !DEC$ ATTRIBUTES ALIAS:'ReadTPs' :: ReadTPs
	 !DEC$ ATTRIBUTES Reference :: 
     $	nTP,nPtTP,xTP,DMITP,xOffTP,fctCrct,Filename
     
      integer nTP,nPtTP(100),lName,iTP,iPt,nTP2
      
      real xTP(2,5000,100),DMITP(100),xOffTP(100),fctCrct(100)
      
      CHARACTER*(lName) Filename
      
      open (5389, file=Filename)
      
      read (5389,*) nTP2
      
      nTP=nTP+nTP2
      
      do iTP=nTP-nTP2+2,nTP+1
        read (5389,*) nPtTP(iTP),
     $   DMITP(iTP),xOffTP(iTP),fctCrct(iTP)
        nPtTP(iTP)=nPtTP(iTP)-1
        do iPt=1,nPtTP(iTP)+1
           read (5389,*) xTP(1,iPt,iTP), xTP(2,iPt,iTP)
        end do
      end do
      
      close (5389)
      end subroutine ReadTPs
      
