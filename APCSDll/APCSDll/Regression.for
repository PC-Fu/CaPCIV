      subroutine Regression(nPt,x,y,a,b)
      implicit none
      
      integer nPt,iPt
      
      real x(nPt),y(nPt)
      
      real a,b,sumX,sumY,sumXX,sumXY,xAve,yAve
      
      sumX=0
      sumY=0
      sumXX=0
      sumXY=0
      
      do iPt=1,nPt
         sumX=sumX+x(iPt)
         sumY=sumY+y(iPt)
         sumXX=sumXX+x(iPt)**2
         sumXY=sumXY+x(iPt)*y(iPt)
      end do
      
      sumXY=sumXY/nPt
      sumXX=sumXX/nPt
      
      xAve=sumX/nPt
      yAve=sumY/nPt
      
      a=(sumXY-xAve*yAve)/(sumXX-xAve**2)
      b=yAve-a*xAve
      
      end subroutine
