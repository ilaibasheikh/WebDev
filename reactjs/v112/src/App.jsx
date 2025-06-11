import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  // const [name, setName] = useState("laiba")
  // const [form,setForm]= useState({email:"",phone:"" })
  const [form,setForm]= useState({})

  const handleclick=()=>{
    alert("i was clicked")
  }
  const handleMouseover=()=>{
    alert("mouse entered red div")
  }
  const handlechange=(e)=>{
  //  setName(e.target.value)
setForm({...form, [e.target.name]: e.target.value})
console.log(form)
  }

  return (
    <>
      <div className="button">
        <button onClick={handleclick}>Click me</button>
      </div>

      <div className="red" onMouseOver={handleMouseover}> i am a red div</div>

      {/* <input type="text" value={name} onChange={handlechange}/> */}

      {/* <input type="text" name="email" value={form.email} onChange={handlechange}/>
      <input type="text" name="phone" value={form.phone} onChange={handlechange}/> */}

      <input type="text" name="email" value={form.email?form.email:""} onChange={handlechange}/>
      <input type="text" name="phone" value={form.phone?form.phone:""} onChange={handlechange}/>

      
    </>
  )
}

export default App
