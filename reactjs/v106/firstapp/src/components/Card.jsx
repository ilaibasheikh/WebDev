import React from 'react'
import "./Card.css"

const Card = (props) => {
  return (
    <div className='card' style={{overflow: "hidden"}}>
        <img src="https://images.unsplash.com/photo-1515879218367-8466d910aaa4?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8Y29kZXxlbnwwfHwwfHx8MA%3D%3D" alt="img1" width={175} height= {75}  />
      <h3>{props.title}</h3>
      <p>{props.description}</p>
    </div>
  )
}

export default Card
