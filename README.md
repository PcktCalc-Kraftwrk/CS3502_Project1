# About
This project requires Oracle Virtual Box and Debian GNU/Linux 12, although the main version of Ubuntu may be used as a substitute.

This code creates a simulated dockyard where ships enter, drop off their cargo and crewmates, and then refresh their inventory before leaving. It also contains an IPC that shows the pipes connecting the process to one another.

# Program.cs

This file holds the main code of the project. At its core, the virtual machine creates a random amount of threads and sends them through a series of statements. It is fuly written in C# and can be easily adjusted for whatever variables the user wnats.

![image](https://github.com/user-attachments/assets/3d387b30-e039-422a-ac07-ced065a5ddd2)

The above section is the setup for the code. This includes the external systems used to create threads and the internal variables created to hold the code together.

![image](https://github.com/user-attachments/assets/611e4c4c-1f69-4b3d-9d36-5c1458862e29)

This is the main() method. Using the randomized loading variable, it creates a new thread that is started in the dock() method, gives it a random ID, and starts it properly.

![image](https://github.com/user-attachments/assets/bf42b50b-9572-4094-9611-7ef832bb6a3c)

The dock() method is a buffer used to call the work method for each thread

![image](https://github.com/user-attachments/assets/3297caf4-fe66-4b57-b00e-2953833540bf)

The dockyard() method is where the meat of the program lies. For each thread sent there, the method annouces when they have entered the port, when they dock inside, their transporting of supplies and manpower, and their departure. It comes with two deadlock stoppers, one to prevent threads from entering and one to prevent them from staying.

# IPC_lsblk.cs

This file holds the inter-proccesor communication
