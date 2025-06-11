
import { useForm } from 'react-hook-form'
import './App.css'

function App() {
  const {
    register,
    handleSubmit,
    setError,
    formState: { errors, isSubmitting },
  } = useForm();

const delay=(d )=>{
  return new Promise((resolve,reject)=>{
    setTimeout(() => {
      resolve()
    }, d*1000);
  })
}
  const onSubmit = async (data) => {
    await delay(2) //network delay
    console.log(data);
    if(data.username!=="laiba"){
      setError("myform",{message:"Your form is not in good error"}) // custom error
    }
     if(data.username==="hani"){
      setError("blocked", {message: "Hani is not allowed"})
    }
  };
  return (
    <>
    {isSubmitting && <div>Loading....</div>}
      <div className="container">
        <form onSubmit={handleSubmit(onSubmit)}>
          <input placeholder='enter username' {...register("username", {required:{value:true, message:"Username is required"}, minLength:{value:3, message:"Min length is 3"}, maxLength:{value:8, message:"Max length is 8"}})} type="text" />
          {errors.username && <div className='red'>{errors.username.message}</div> }

          <input placeholder='enter password' {...register("password", {required:{value:true, message:"Password is required" }, minLength:{value:5, message:"Min length is 5"}, maxLength:{value:10, message:"Max length is 10"}})} type="password" />
          {errors.password && <div className='red'>{errors.password.message}</div> }

          <input disabled={isSubmitting} type="submit" value="Submit" />
          {errors.myform && <div className='red'>{errors.myform.message}</div> }
          {errors.blocked && <div className='red'>{errors.blocked.message}</div> }
        </form>
      </div>
    </>
  )
}

export default App
