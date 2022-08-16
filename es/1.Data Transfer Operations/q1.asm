	AREA RESET,DATA,READONLY
	EXPORT __Vectors
__Vectors
	DCD 0x10001000
	DCD Reset_Handler
	ALIGN
	AREA mycode, CODE, READONLY
	ENTRY
	EXPORT Reset_Handler
Reset_Handler
; code here 
	LDR R0,=SRC
	LDR R1,=DST
	LDR R10,=0XA
BACK
	LDR R2,[R0],#4
	STR R2,[R1],#4
	SUBS R10,#1
	BNE BACK
STOP B STOP
	AREA mydata, DATA, READWRITE
; reserve memory in RAM here
SRC DCD 0,0,0,0,0,0,0,0,0,0
DST DCD 0,0,0,0,0,0,0,0,0,0
	END