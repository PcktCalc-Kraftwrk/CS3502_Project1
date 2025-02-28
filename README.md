# About
This project requires Oracle Virtual Box and Debian GNU/Linux 12, although the main version of Ubuntu may be used as a substitute.

This code creates a simulated dockyard where ships enter, drop off their cargo and crewmates, and then refresh their inventory before leaving. It also contains an IPC that shows the pipes connecting the process to one another.

# Program.cs

This file holds the main code of the project. At its core, the virtual machine creates a random amount of threads and sends them through a series of statements. It is fuly written in C# and can be easily adjusted for whatever variables the user wnats.

![image](https://github.com/user-attachments/assets/3d387b30-e039-422a-ac07-ced065a5ddd2)

The above section is the setup for the code. This includes the external systems used to create threads and the internal variables created to hold the code together.

