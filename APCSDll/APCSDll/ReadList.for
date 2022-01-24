	subroutine ReadList(iImage,nImage,Filename,lName)

      ! reading the image list is now being performed by vb.  This subroutine is not used anymore.

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadList
	 !DEC$ ATTRIBUTES ALIAS:'ReadList' :: ReadList
	 !DEC$ ATTRIBUTES Reference :: 
     $	iImage,nImage,Filename
	
	
	integer iImage,nImage,lName,lCurDir,i
	
      CHARACTER*(lName) Filename

      if (iImage.eq.-1) then

        open (7475, file=filename)
        read (7475, *) nImage
        nImage=nImage-1

      end if

      if ((iImage.ge.0).and.(iImage.le.nImage)) then
      
        rewind (7475)
        do i=0,iImage
            Read (7475,*)
        end do
        
        read (7475, *) Filename
        
      
      end if 
      
      if (iImage.eq.nImage+1) then
        close (7475)
      end if



      end subroutine ReadList
      
