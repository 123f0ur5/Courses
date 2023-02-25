import locationImg from '../assets/img/Path.png'
import './style.css'

export default function Card(props){
    console.log(props.item.title)
    return (
    <div className="card">
        <div className='card--image-cover'>
            <img src={props.item.imageUrl}/>
        </div>
        <div className='info'>
            <p><img className="card--location-img" src={locationImg} /> {props.item.location} <a href={props.item.googleMapsUrl}>View on GoogleMaps</a></p>
            <h1>{props.item.title}</h1>
            <p>{props.item.startDate} - {props.item.endDate}</p>
            <p>{props.item.description}</p>
        </div>
    </div>)
}