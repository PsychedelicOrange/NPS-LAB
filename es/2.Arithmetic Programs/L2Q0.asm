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
	LDR R0,=NUM1
	;R1 WILL HAVE NUM1 VALUE

	LDR R2,=RES
	;R6 HAS CARRY
	;R7 HAS SUM
	ldr R8,=0xa
	
back
	LDR R1,[r0],#4
	ADDS R7,R1
	ADC R6,#0
	SUB R8,#1
	TEQ r8,#0
	BNE back
	STM R2,{R6,R7}
STOP B STOP
NUM1 DCD 0XffffFFFe,0x12,0x13,0x32,0x43,0x45,0x56,0x65,0x2,0x1
	AREA mydata, DATA, READWRITE
RES DCD 0,0
; reserve memory in RAM here

	END