import data from './data.js'
import Card from './components/Cards.js'
import Header from './components/Header.js'

function App() {
  const cards = data.map(card => {return(
    <Card item={card}/>
  )})
  return (
    <>
      <Header />
      <div className='cards'>
        {cards}
      </div>
    </>
  );
}

export default App;
