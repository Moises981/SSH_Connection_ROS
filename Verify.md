# Optional (If there are problems try this):
To verify the connection let's type in ubuntu:

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
Create a folder in ubuntu to mount the shared folder of windows.
```bash
sudo mount -t cifs -o username=,password=,dir_mode=0777,file_mode=0777 //[IP_address]/[Name of the shared folder] [Path of the folder in ubuntu]
```
Example:
```bash
sudo mount -t cifs -o username=,password=,dir_mode=0777,file_mode=0777 //192.168.2.244/Testing /home/asus/Desktop/Test
```
Then umount the shared folder to avoid problems.
```bash
sudo umount /home/asus/Desktop/Testing 
```
Finally check if the shared folder is working, trying to sharing files.
