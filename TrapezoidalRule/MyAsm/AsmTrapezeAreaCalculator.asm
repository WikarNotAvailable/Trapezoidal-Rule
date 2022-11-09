.data
dwa dq 2.0
.code
CalculateAreaOfTrapeze proc 
movsd   xmm4, QWORD PTR [rsp+40]

movlhps xmm3, xmm4
subsd xmm4, xmm3
movlhps xmm4, xmm4
movlhps xmm0, xmm0
movlhps xmm1, xmm1
movlhps xmm2, xmm2

mulpd xmm0, xmm3
mulpd xmm0, xmm3
mulpd xmm1, xmm3

ADDPD xmm0, xmm1
ADDPD xmm0, xmm2
mulpd xmm0, xmm4

movapd xmm5, xmm0

mulpd xmm0, xmm7

movhlps xmm0, xmm5
addsd xmm0, xmm5

divsd xmm0, [dwa]
ret
CalculateAreaOfTrapeze endp
end
