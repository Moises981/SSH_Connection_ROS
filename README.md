 # Send rostopic messages from windows to ubuntu with SSH client
 
 [Create the shared folder](Shared_folder.md) in windows:
 
 ### Install 
 
 Install cifs tools to mount:
```bash
sudo apt-get install cifs-utils
```
Install ssh-server to connect:
```bash
sudo apt-get install openssh-server
```
If there are problems try to install samba:
```bash
sudo apt-get install samba
```
 
 ### Compile the packages (Server folder) in ROS
 ```bash
 catkin_make
 ```
 ```bash
 source devel/setup.bash
 ```
 ### Configure the server parameters with roslaunch
 ```bash
 roslaunch server_node Mount_Client.launch shared_folder:=" " folder:=" " sudo_password:=" "
 ```
 **Arguments:**
 + shared_folder is the path of the folder that you create in ubuntu.
 + folder is the path of the folder that you want to share between ubuntu and windows.
 + sudo_password is the password of your account in ubuntu , it's important to execute sudo commands.
 
 Example:
 ```bash
 roslaunch server_node Mount_Client.launch shared_folder:="/home/asus/Desktop/Testing" folder:="/home/asus/Desktop/Catkin_ws/src/server_node/Backup" sudo_password:="Playtec981"
 ```
 
### Open the exe file in Windows (Client folder)
Open the file Testing.exe that is in the Client folder.

![Main](https://user-images.githubusercontent.com/59718261/89586810-faa86f00-d805-11ea-9f4a-e690d90d3b5b.PNG)

**Variables:**
+ IP del servidor : IP of ubuntu , if you want to visualize type this command.
```bash
sudo apt install net-tools
```
```bash
ifconfig
```
Then search your ip address.

![Capture](https://user-images.githubusercontent.com/59718261/89587132-9639df80-d806-11ea-885b-734109a246c5.PNG)
 
 In this case the server ip is "192.168.172.130"
 
 + Nombre de la carpeta compartida : The name of the shared folder 
 + Username: This is the username of the ubuntu server
 + Password: This is the password of ubuntu
 + Local IP: This is the IP address of the windows computer.
 You can see it , just type in cmd "ipconfig" and search your ip address.
 
Example: 

![Menu](https://user-images.githubusercontent.com/59718261/89586695-ce8cee00-d805-11ea-8413-294636d74fc2.PNG)

 ### Problems
 If there are problems try to [verify the connection](Verify.md).








