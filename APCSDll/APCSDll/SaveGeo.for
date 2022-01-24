	subroutine SaveGeo(nRefGeo,xPixRefGeo,coorGeo,
     $	numPDS,xPixPDSLine,flagManualPDSLine,
     $  Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: SaveGeo
	 !DEC$ ATTRIBUTES ALIAS:'SaveGeo':: SaveGeo
	 !DEC$ ATTRIBUTES Reference :: 
     $  nRefGeo,xPixRefGeo,coorGeo,
     $	numPDS,xPixPDSLine,flagManualPDSLine,
     $  Filename
     
      integer nRefGeo,numPDS,lName,i
      integer xPixRefGeo(2,1000),xPixPDSLine(2,2,numPDS+1),
     $  flagManualPDSLine(2,numPDS+1) 
      
      double precision  coorGeo(3,1000)
      
      CHARACTER*(lName) Filename
            
      open (5437,file=Filename)
      
      write (5437,'(2I8)') 1,numPDS !nRefGeo,numPDS
            
      do i=1, 2 !nRefGeo+1
      
        write (5437,'(2I12,3E16.8)') xPixRefGeo(1,i),xPixRefGeo(2,i),
     $    coorGeo(1,i),coorGeo(2,i),coorGeo(3,i)
      
      end do
      
      do i=1,numPDS+1
      
        write (5437,'(6I12)') xPixPDSLine(1,1,i),
     $    xPixPDSLine(2,1,i),xPixPDSLine(1,2,i),xPixPDSLine(2,2,i),
     $    flagManualPDSLine(1,i),flagManualPDSLine(2,i)
      
      end do
      
      close (5437)
      
      end subroutine SaveGeo

