import React , {useEffect} from 'react'

const Navbar = ({color}) => {
    useEffect(() => {
      
    alert("color was updated")
    
      
    }, [color])
    
  return (
    <div>
      i am navbar of color {color} hehe
    </div>
  )
}

export default Navbar
