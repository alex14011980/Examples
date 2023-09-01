int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int count = 0;
int time = 0;
int friend = 2;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 2;
    }
    
    if(friend == 2)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 1;
    }
     
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}
Console.Write("Собака пробежит ");
Console.WriteLine(count + " раз");
