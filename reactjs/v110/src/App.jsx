import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [count, setCount] = useState(0)
  const [showbtn, setshowbtn] = useState(false)

  const [todos, setTodos] = useState([
    { title: "Title", desc: "Description" },
    { title: "Title2", desc: "Description2" },
    { title: "Title3", desc: "Description3" },])


  const Todo = ({ todo }) => {
    return (<>
      <div className="m-4 border-1">
        <div className="todo">
          {todo.title}
        </div>
        <div>
          {todo.desc}
        </div>
      </div>
    </>)
  }




  return (
    <>
      <div>
        <a href="https://vite.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>



      {todos.map(todo => {
        return <Todo key={todo.title} todo={todo} />
      })

      }


      {/* {showbtn?<button>shown when another clicked</button>:""} */}
      {showbtn && <button>shown when another clicked</button>}
      <div className="card">
        <button onClick={() => setshowbtn(!showbtn)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.jsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
    </>
  )
}

export default App
