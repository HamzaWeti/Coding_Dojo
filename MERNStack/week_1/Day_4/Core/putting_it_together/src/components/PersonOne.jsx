import React from "react";
import { useState } from 'react';
const PersonOne = (Props) => {//console.log(Props);
    const [age, setAge] = useState(Props.person.age)
    const increaseAge =()=>{
        setAge(age+1)
    }
    return(
    <fieldset>
        <h4>Username : {Props.person.lastName}, {Props.person.firstName}</h4>
        <h4>Age : {age}</h4>
        <h4>Hair Color : {Props.person.hairColor}</h4>
        <button onClick={()=> increaseAge(Props.person.age)}>HappyBirthday</button>
    </fieldset>
    )
}
export default PersonOne