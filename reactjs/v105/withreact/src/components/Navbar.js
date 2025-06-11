import React from 'react'
import Footer from './Footer'

const Navbar = (props) => {
  return (
    <div>
      <div className="logo">{props.logotext}</div>
      <ul>
        <li>home</li>
        <li>about</li>
        <li>contact us</li>
      </ul>
      <Footer />
    </div>
  )
}

export default Navbar

