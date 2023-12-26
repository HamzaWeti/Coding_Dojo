import './App.css';
import PersonOne from './components/PersonOne';

function App() {
  const people = [
    {firstName:"John", lastName:"Doe", age:45, hairColor:"Black"}, 
    {firstName:"Alex", lastName:"Smith", age:88, hairColor:"Brown"},
    {firstName:"Sarah", lastName:"Fillmore", age:50, hairColor:"Brown"}];
    
  return (
    <div className="App">
      {people.map((person, idx)=><PersonOne key={idx} person={person}/>)}
      
    </div>
  );
}

export default App;