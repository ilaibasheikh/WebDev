import React from 'react'
import { Link } from 'react-router-dom'
import { NavLink } from 'react-router-dom'


const Navbar = () => {
    
  return (
    <div>

    <nav>
        {/* <a href="/Home"><li>Home</li></a>
        <a href="/About"><li>About</li></a>
        <a href="/Login"><li>Login</li></a> */}

        {/* <Link to="/Home"><li>Home</li></Link>
        <Link to="/About"><li>About</li></Link>
        <Link to="/Login"><li>Login</li></Link> */}
 
        <NavLink className={(e)=>{return e.isActive?"red":""}} to="/Home"><li>Home</li></NavLink>
        <NavLink className={(e)=>{return e.isActive?"red":""}} to="/About"><li>About</li></NavLink>
        <NavLink className={(e)=>{return e.isActive?"red":""}} to="/Login"><li>Login</li></NavLink>
      
    </nav>
        </div>
  )
}

export default Navbar
