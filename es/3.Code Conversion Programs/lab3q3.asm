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
	LDR R0,=HEX
    MOV R5,#0
    MOV R7,#32
    LDR R1,[R0]

UP2 BL DIVIDE
    CMP R1,#0
    BNE UP2
    LDR R0,=BCD
    LSR R5,R7
    STR R5,[R0]

STOP B STOP

DIVIDE MOV R3,#0
UP1 
    CMP R1,#0X0A
	BLO DOWN
	SUB R1,#0X0A
	ADD R3,#1
	B UP1
DOWN
    ORR R5,R1
	ROR R5,#4
    MOV R1,R3
    SUB R7,#4
    BX LR

HEX DCD 0XA7
	AREA MYDATA,DATA, READWRITE
BCD DCD 0
	END