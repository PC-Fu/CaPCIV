	subroutine SaveDistress(nImage,numCrack,numPtCrack,
     $xPixPtCrack,iTypeCrack,lCrack,
     $attrbCrack,Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: SaveDistress 
	 !DEC$ ATTRIBUTES ALIAS:'SaveDistress':: SaveDistress
	 !DEC$ ATTRIBUTES Reference :: 
     $	nImage,numCrack,numPtCrack,
     $xpixPtCrack,iTypeCrack,lCrack,
     $attrbCrack,Filename
	
	
	integer nImage,numCrack,lName,i,j
	integer numPtCrack(nImage*1000),xPixPtCrack(2,20,nImage*1000),
     $      iTypeCrack(nImage*1000),attrbCrack(nImage*1000)	
      real lCrack(nImage*1000)
      CHARACTER*(lName) Filename
      
      open (3453,file=Filename)
      
      write (3453,*) numCrack, "Num. of distresses"
      write (3453,'(10000I8)')  (numPtCrack(i),i=1,numCrack+1)
      write (3453,'(10000I8)')  (iTypeCrack(i),i=1,numCrack+1)
      write (3453,'(10000I8)')  (attrbCrack(i),i=1,numCrack+1)
      
      do i=1, numCrack+1
        write (3453,'(10000I8)')  
     $   (xPixPtCrack(1,j,i),j=1,numPtCrack(i)+1),
     $   (xPixPtCrack(2,j,i),j=1,numPtCrack(i)+1)
      end do
      
      write (3453,'(10000E13.5)')  (lCrack(i),i=1,numCrack+1)
      close (3453)
      
      end subroutine SaveDistress
      
