import locationImg from '../assets/img/location.png'
import './style.css'

export default function Card(props){
    return (
    <div className="card">
        <div className='card--image-cover'>
            <img src={props.item.imageUrl}/>
        </div>
        <div className='info'>
            <div className='card--info-box'>
                <img className="card--info-location-icon" src={locationImg} /> 
                <span className='card--info-location'>{props.item.location}</span>
                <a className='card--info-maps' href={props.item.googleMapsUrl}>View on GoogleMaps</a>
            </div>
            <span className='card--info-title'>{props.item.title}</span>
            <span className='card--info-date'>{props.item.startDate} - {props.item.endDate}</span>
            <span className='card--info-description'>{props.item.description}</span>
        </div>
    </div>)
}