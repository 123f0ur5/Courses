import fbIcon from '../assets/images/FacebookIcon.png'
import gitIcon from '../assets/images/GitHubIcon.png'
import instaIcon from '../assets/images/InstagramIcon.png'
import twtIcon from '../assets/images/TwitterIcon.png'

export default function Footer(){
    return (
        <footer className='footer'>
            <img src={twtIcon} />
            <img src={fbIcon} />
            <img src={instaIcon} />
            <img src={gitIcon} />
        </footer>
    );
}