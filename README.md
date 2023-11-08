# HH.CanOTo
Build software to manage freight vehicle scales.
The important point is to connect with COM1 PORT to get data from the electronic scale.
## Develop and Test with Virtual Port.
1. use "virtual serial port driver" create connection from COM2 to COM1.
2. `python createPort.py` to send data between COM2 to COM1 every second.
3. run terminal.exe in references folder to check COM1 connection.
