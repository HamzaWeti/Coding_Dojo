class Pet:
    def__init__(self,name,pet_type,tricks):
        self.name = name
        self.pet_type = pet_type
        self.tricks = tricks
        self.helth = 100
        self.energy = 100


    def sleep(self):
        self.energy += 25


    def eat(self):
        self.energy +=5
        self.helth +=10
    

    def play (self):
        self.helth +=5

    def noise(self):
        if(self.pet_type == "dog"):
            print("woof !")
        elif(self.pet_type == "cat"):
            print("meow !")
        else:
            print("haaaa !")



pet1 = pet("Fluffy", "Dog", ["Sit", "Rol over"])

