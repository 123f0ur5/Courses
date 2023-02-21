import photo from '../assets/images/photo.png'
import linkedin from '../assets/images/linkedin.png'
import mail from '../assets/images/Mail.png'

export default function Info(){
    return (
        <div className='info'>
            <img className='info--photo' src={photo} />
            <span className='info--name'>Laura Smith</span>
            <span className='info--occupation'>Frontend Developer</span>
            <span className='info--website'>laurasmith.website</span>
            <div className='info--buttons'>
                <span className='info--button-email'><img src={mail}/>Email</span>
                <span className='info--button-linkedin'><img src={linkedin}/>LinkedIn</span>
            </div>
        </div>
    );
}