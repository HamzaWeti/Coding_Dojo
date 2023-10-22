// predict 1 
function myBirthYearFunc(){
    console.log("I was born in" + 1980);
}
myBirthYearFunc();
// when the myBirthYearFunc function is  called . it will consol.log 
//juste "I was born in"
//and 1980 he is input inundefiend


//predict 1
function myBirthYearFunc(birthYearInput){
    console.log("I was born in" + birthYearInput);
}
myBirthYearFunc(1980);
// he is  consol.log "i was born in 1980"


//predict 3
function add(num1, num2){
    console.log("Summing Numbers!");
    // 1) logs "summing Numbers!" is fixed
    console.log("num1 is: " + num1);
    // 2) logs "num1 is" and the value of num1 10
    console.log("num2 is: " + num2);
    // 3) logs "num2 is" and the value of num2 20
    var sum = num1 + num2;
    // 4) var sum = num1 + num2 calculat the sum of 'num1' + 'num2' = 30
    console.log(sum);
    // 5) consol.log 30
}
add(10, 20);

