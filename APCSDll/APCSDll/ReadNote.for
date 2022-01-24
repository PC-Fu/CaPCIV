	subroutine ReadNote(nNote,coorGeo,
     $	noteGeo,lNote,Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadNote
	 !DEC$ ATTRIBUTES ALIAS:'ReadNote':: ReadNote
	 !DEC$ ATTRIBUTES Reference :: nNotes,coorGeo,
     $	noteGeo,Filename

      integer nNote,lName,lNote
      
      double precision  coorGeo(3)
      
      real linRefGeo(1000)
      
      CHARACTER*(lName) Filename
      CHARACTER*(lNote) noteGeo

      if (nNote.eq.0) then
            
        open (9387,file=Filename)
        
        do while (.not.eof(9387))
            read (9387,*) noteGeo
            nNote=nNote+1  
        end do
        
        rewind (9387)
      else if (nNote.eq.-1) then
        close (9387) 
      else
        
        read (9387,*)  coorGeo(2),coorGeo(1),noteGeo
      
      end if
      
      
      end subroutine
      
      