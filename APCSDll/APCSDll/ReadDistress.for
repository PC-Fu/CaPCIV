	subroutine ReadDistress(nImage,numCrack,numPtCrack,
     $xPixPtCrack,iTypeCrack,lCrack,
     $attrbCrack,Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadDistress 
	 !DEC$ ATTRIBUTES ALIAS:'ReadDistress':: ReadDistress
	 !DEC$ ATTRIBUTES Reference :: 
     $	nImage,numCrack,numPtCrack,
     $xpixPtCrack,iTypeCrack,lCrack,
     $attrbCrack,Filename
	
	
	integer nImage,numCrack,lName,i,j
	integer numPtCrack(nImage*1000),xPixPtCrack(2,20,nImage*1000),
     $      iTypeCrack(nImage*1000),attrbCrack(nImage*1000)	
      real lCrack(nImage*1000)
      CHARACTER*(lName) Filename
      
      open (4823,file=Filename)
      
      read (4823,*) numCrack
      read (4823,*)  (numPtCrack(i),i=1,numCrack+1)
      read (4823,*)  (iTypeCrack(i),i=1,numCrack+1)
      read (4823,*)  (attrbCrack(i),i=1,numCrack+1)
      
      do i=1, numCrack+1
        read (4823,*)  
     $   (xPixPtCrack(1,j,i),j=1,numPtCrack(i)+1),
     $   (xPixPtCrack(2,j,i),j=1,numPtCrack(i)+1)
      end do
      
      read (4823,*)  (lCrack(i),i=1,numCrack+1)
      close (4823)
      
      end subroutine ReadDistress
      
