import { useState, useEffect } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Navbar from './components/Navbar'

function App() {
  const [cards, setCards] = useState([])
  const fetchData = async () => {
    let a = await fetch(" https://jsonplaceholder.typicode.com/posts")
    let data = await a.json()
    setCards(data)
    console.log(data)
  }

  useEffect(() => {
    fetchData()
  }, [])


  return (
    <>
    <Navbar/>
      <div className="container">

        {cards.map(props => {
          return <div  key={props.id} className="card">
            <h1>{props.title}</h1>
            <p>{props.body}</p>
            <span>BY USER ID :{props.userId}</span>
          </div>
        })}

      </div>
    </>
  )
}

export default App
