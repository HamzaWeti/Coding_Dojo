import './App.css';
import PersonCard from './components/PersonCard';

function App() {
  const people = [
    {firstName:"John", lastName:"Doe", age:"45", hairColor:"Black"}, 
    {firstName:"Alex", lastName:"Smith", age:"88", hairColor:"Brown"},
    {firstName:"Sarah", lastName:"Fillmore", age:"50", hairColor:"Brown"}];
  return (
    <div className="App">
      {people.map((person, idx)=><PersonCard key={idx} person={person}/>)}
    </div>
  );
}

export default App;
