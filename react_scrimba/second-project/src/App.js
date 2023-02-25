import data from './data.js'
import Card from './components/Cards.js'

function App() {
  const cards = data.map(card => {return(
    <Card item={card}/>
  )})
  return (
    <>
      {cards}
    </>
  );
}

export default App;
