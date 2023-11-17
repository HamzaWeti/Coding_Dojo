
class User:
    
    def __init__(self, first_name, last_name, email, age, is_rewards_member=False, gold_card_points=0):
        self.first_name = first_name
        self.last_name = last_name
        self.email = email
        self.age = age
        self.is_rewards_member = False
        self.gold_card_points = 0

    def display_info(self):
        print(f"Name: {self.first_name} {self.last_name}")
        print(f"Email: {self.email}")
        print(f"Age: {self.age}")
        print(f"Member: {self.is_rewards_member}")
        print(f"Points: {self.gold_card_points}")

    def enroll(self):
        self.is_rewards_member = True
        self.gold_card_points = 200 
        if (self.is_rewards_member == True):
            print("User is already a member")
            return False
        else:
            return True


    def spend_points(self,amount):
        self.gold_card_points=100
        if(self.gold_card_points < amount ):
            return False



user1=User("hamza" , "weti" , "abc@gmail.com" , "300")
print(user1)
user1.display_info().enroll().spend_points(50).display_info()

user2=User("Jack" , "Mack" , "xyz@gmail.com" ,"90")
print(user2)
user2.enroll().spend_points(80).display_info()
chaining.py