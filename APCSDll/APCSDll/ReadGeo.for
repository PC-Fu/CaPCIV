	subroutine ReadGeo(nRefGeo,xPixRefGeo,coorGeo,
     $	numPDS,xPixPDSLine,flagManualPDSLine,
     $  flagNew,Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadGeo
	 !DEC$ ATTRIBUTES ALIAS:'ReadGeo':: ReadGeo
	 !DEC$ ATTRIBUTES Reference :: 
     $  nRefGeo,xPixRefGeo,coorGeo,
     $	numPDS,xPixPDSLine,flagManualPDSLine,flagNew,
     $  Filename
  
      integer nRefGeo,numPDS,lName,i,flagNew(2)
      integer xPixRefGeo(2,1000),xPixPDSLine(2,2,numPDS+1),
     $  flagManualPDSLine(2,numPDS+1) 
      
      double precision  coorGeo(3,1000)
      
      CHARACTER*(lName) Filename
  
      open (5623,file=Filename)
       
      if (flagNew(1).eq.0) then
        read (5623,*) flagNew(1),flagNew(2)
      else
      
        read (5623,*)  ! Skip the first line, because nRefGeo and numPDS are already known
        do i=1, flagNew(1)+1
      
            Read (5623,*) xPixRefGeo(1,i),xPixRefGeo(2,i),
     $      coorGeo(1,i),coorGeo(2,i),coorGeo(3,i)
      
        end do
      
        do i=1,numPDS+1
      
            read (5623,*) xPixPDSLine(1,1,i),
     $      xPixPDSLine(2,1,i),xPixPDSLine(1,2,i),xPixPDSLine(2,2,i),
     $      flagManualPDSLine(1,i),flagManualPDSLine(2,i)
      
        end do
      
      end if
       
           
      close (5623)
      
      end subroutine ReadGeo