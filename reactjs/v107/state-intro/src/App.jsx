import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
     
{/*         
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
  
      </div> */}
      <div>
        the count is {count}
      </div>
      <button onClick={()=>{setCount(count+1)}}> Update Count</button>
     
    </>
  )
}

export default App
