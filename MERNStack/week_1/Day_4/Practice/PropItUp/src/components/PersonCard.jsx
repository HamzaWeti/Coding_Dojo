import React from "react";
const PersonCard = (Props) => {console.log(Props);
    return(
    <fieldset>
        <h4>Username : {Props.person.lastName}, {Props.person.firstName}</h4>
        <h4>Age : {Props.person.age}</h4>
        <h4>Hair Color : {Props.person.hairColor}</h4>
    </fieldset>
    )
}
export default PersonCard