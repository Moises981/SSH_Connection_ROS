### Verify connection
To verify the connection let's type in ubuntu:

Create a folder in ubuntu to mount the shared folder of windows.
```bash
sudo mount -t cifs -o username=,password=,dir_mode=0777,file_mode=0777 //[IP_address]/[Name of the shared folder] [Path of the folder in ubuntu]
```
Example:
```bash
sudo mount -t cifs -o username=,password=,dir_mode=0777,file_mode=0777 //192.168.2.237/Testing /home/asus/Desktop/Test
```
Check if the folder is working and sharing files between windows and ubuntu , if all works fine umount it.
Then umount the shared folder to avoid problems.
```bash
sudo umount /home/asus/Desktop/Testing 
```
### Test ping
Check if there is connection between then:
**Windows Client**
Open cmd and then type:
```bash
ping [IP of ubuntu]
```
**Ubuntu Server**
Open the terminal and type:
```bash
ping [IP of windows]
```
### Read the errors from the rostopic
For example:

![Capture](https://user-images.githubusercontent.com/59718261/89586680-c8970d00-d805-11ea-96fe-e9953742bbca.PNG)

If this errors appears try to verify if you have created the folder in ubuntu.

![Capture](https://user-images.githubusercontent.com/59718261/89589051-80c6b480-d80a-11ea-869d-b489a8061df8.PNG)

This is a warn that said that you haven't connect to the server from the application (Testing.exe) yet.

