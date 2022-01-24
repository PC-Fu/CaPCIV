      	subroutine ReadLongPro(nRsv,nPtPro,
     $	xPtPro,proAll,boundPro,Filename,lName)
      
	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadLongPro
	 !DEC$ ATTRIBUTES ALIAS:'ReadLongPro':: ReadLongPro
	 !DEC$ ATTRIBUTES Reference :: 
     $ nRsv,nPtPro,xPtPro,proAll,boundPro,Filename
     
      integer nRsv,nPtPro,iPt,lName,j
      
      real xPtPro(nRsv),boundPro(2,10),proAll(nRsv,10)
      
      character *(lName) Filename
      
      open (3433,file=FileName,form="unformatted")
      
      Read (3433) nPtPro
      
      Read (3433) (xPtPro(iPt),iPt=1,nPtPro)
      
      do j=1,10
        Read (3433) boundPro(1,j),boundPro(2,j),
     $               (proAll(iPt,j),iPt=1,nPtPro)
      end do
      
      end subroutine
