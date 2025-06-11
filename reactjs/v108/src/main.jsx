import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'

createRoot(document.getElementById('root')).render(
  // <StrictMode> //runs code twice, once during development to check and once in production actual
    <App />
  // </StrictMode>,
)
