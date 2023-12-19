class Ninja {
    constructor(name){
        this.name = name;
        this.health = 90;
        this.speed = 3;
        this.strength = 3;

    }
    sayName() {
        console.log(this.name)
        
    }
    showStats() {
        console.log(`name= ${this.name}-- health= ${this.health}-- speed ${this.speed}-- strength ${this.strength}`);
    }
    drinkSake(){
        this.health +=10
    }
}


class Sensei extends Ninja  {   
    constructor(name, wisdom){
        super(name, 200, 10, 10);
        this.name = name;
        this.wisdom = 10;
    }
    speakWisdom(){
        super.drinkSake
    }
}
const ninja1 = new Ninja("Hyabusa");
ninja1.sayName();
ninja1.showStats();
console.log(`What one programmer can do in one month, two programmers can do in two months`)