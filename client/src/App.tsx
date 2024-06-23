import {Route, Routes} from 'react-router-dom'
import './sass/main.scss'
import DetailPage from './pages/DetailPage'
import Homepage from './pages/Homepage'
import LoginPage from './pages/LoginPage'
import Navigation from './components/Navigation'

function App() {
    return (
        <>
            <Navigation/>
            <Routes>
                <Route path='/' element={<Homepage/>}/>
                <Route path='/login' element={<LoginPage/>}/>
                <Route path='/detail' element={<DetailPage/>}/>
            </Routes>
        </>
    );
}

export default App;
