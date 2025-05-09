Make a call : ATD+668175?????; call 08175?????
Disconnect / hangup call : ATH = Disconnect Existing Connection
ANSWER AN INCOMING CALL : ATA
Redial Last Telephone Number Used : ATDL
Display Product Identification Information : ATI   => "SIM900A R11.0"
Display Current Configuration : AT&V
=>
ACTIVE PROFILE:
E1 Q0 V1 X4 &C1 &D1 +IFC= 0,0 +FCLASS0
S00:0 S03:13 S04:10 S05:8 S07:60 S08:2 S10:15
STORED PROFILE 0:
E1 Q0 V1 X4 &C1 &D1 +IFC= 0,0 +FCLASS0
S00:0 S03:13 S04:10 S05:8 S07:60 S08:2 S10:15
STORED PROFILE 1:
E1 Q0 V1 X4 &C1 &D1 +IFC= 0,0 +FCLASS0
S00:0 S03:13 S04:10 S05:8 S07:60 S08:2 S10:15
OK
Request Manufacturer Identification : AT+GMI  => "SIMCOM_Ltd"
Request TA Serial Number Identification (IMEI) : AT+GSN => "???????????????"
AT+CSQ => "+CSQ: 17,0" : Response Format: +CSQ: <rssi>,<qual>
Checks supported configurations / services of the modem : AT+CREG=? => "+CREG: (0-2)"
 – meaning that 0,1,2 can be set in the AT+CREG command
AT+CCID => "????????????????????"   - returning the SIM card identifier (ICCID)
AT+CNUM  => "+CNUM: "","082???????",129,7,4"
BATTERY CHARGE : AT+CBC => "+CBC: 0,100,4274" - +CBC: connection_status,charge_level
Read the Service Center Address : AT+CSCA? => "+CSCA: "+669????????",145"
Accumulated Call Meter (ACM) Reset or Query : AT+CACM
AT+CACM? => "+CACM: 000000"
AT+CLCC? => "+CLCC: 0"

RING <=== มีสายเรียกเข้า
AT+CLCC <=== terminal ส่ง command AT+CLCC
+CLCC: 1,1,4,0,0,"091???????",161,""  <=== terminal แสดง เบอร์ โทร ของ สายเรียกเข้า
