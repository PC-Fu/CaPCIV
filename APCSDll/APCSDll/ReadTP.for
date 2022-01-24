	subroutine ReadTP(nTP,nPtTP,xPtTP,proTRaw,dmiTP,Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadTP
	 !DEC$ ATTRIBUTES ALIAS:'ReadTP':: ReadTP
	 !DEC$ ATTRIBUTES Reference :: 
     $  nTP,nPtTP,xPtTP,proTRaw,dmiTP,Filename
     
      integer nTP,nPtTP(1000),lName,iTP,iPt
    
      real xPtTP(10000,1000),proTRaw(10000,1000),scaleX,dmiTP(1000)
           
      CHARACTER*(lName) Filename
      character *60 ProFile

      
      scaleX=-0.5
      
      open (5849, file=Filename)
      
      read (5849,*) nTP
      
      
      
      do iTP=1,nTP
        read (5849,'(A60)') ProFile
        read (5849,*) dmiTP(iTP)
        
        open (3829, file=ProFile)
        
        read (3829,*)
        read (3829,*)
        read (3829,*)
        read (3829,*)
        read (3829,*)
        read (3829,*)
      
        nPtTP(iTP)=0
        do while (.not.EOF(3829))        
            
            nPtTP(iTP)=nPtTP(iTP)+1
            read (3829,*) xPtTP(nPtTP(iTP),iTP),proTRaw(nPtTP(iTP),iTP)
        
        end do
        
        
        
        close (3829)
        
      
      end do
      
      xPtTP=xPtTP*scaleX/1000
      proTRaw=proTRaw/1000
      
      end subroutine