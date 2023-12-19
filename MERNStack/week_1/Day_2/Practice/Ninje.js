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
    showStates() {
        console.log(`name= ${this.name}-- health= ${this.health}-- speed ${this.speed}-- strength ${this.strength}`);
    }
    drinkSake(){
        this.health +=10
    }
}

const ninja1 = new Ninja("Hyabusa");
ninja1.sayName();
ninja1.showStates();
