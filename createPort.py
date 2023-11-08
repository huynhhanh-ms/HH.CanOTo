import serial, random, time

# print(dir(serial))
def createPort(portName, baudRate):
    # Tạo cổng COM ảo
    ser = serial.Serial(
        port=portName,
        baudrate=9600,
        bytesize=serial.EIGHTBITS,
        parity=serial.PARITY_NONE,
        stopbits=serial.STOPBITS_ONE,
        xonxoff=False,
        rtscts=False,
        dsrdtr=False
    )
    return ser

ser = createPort("COM2", 9600)

#delete com port virtual
# import serial.tools.list_ports
# ports = serial.tools.list_ports.comports()
# for port, desc, hwid in sorted(ports):
#     if "USB Serial Port" in desc:
#         print("Deleting {}".format(port))
#         serial.tools.list_ports.comports().remove(port)

cnt = 0
try:
    while True:
        # Tạo số ngẫu nhiên từ 1 đến 100
        # random_data = str(random.randint(1, 100))
        # random_data = "+00000001B"
        random_data = str(cnt)
        cnt += 1
        
        # Gửi dữ liệu qua cổng COM
        ser.write(random_data.encode())

        print(f"Sent: {random_data}")

        # Chờ một khoảng thời gian ngẫu nhiên trước khi gửi dữ liệu tiếp theo
        time.sleep(1)

except KeyboardInterrupt:
    pass

# Kiểm tra xem cổng đã mở chưa
if ser.is_open:
    print(f"COM port {ser.port} is open.")
else:
    print(f"Failed to open COM port {ser.port}.")

# # Đóng cổng COM khi không cần thiết
ser.close()