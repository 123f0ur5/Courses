import world from '../assets/img/globe.png'

export default function Header(){
    return (
        <div className="header">
            <img className='header--globe' src={world} />
            <span>my travel journal.</span>
        </div>
    )
}