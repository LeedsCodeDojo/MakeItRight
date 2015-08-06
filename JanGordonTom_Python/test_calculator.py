import operator
import pytest

def calculate(eval_str):
    ops = {
	'+': operator.add,
        '-': operator.sub,
        '*': operator.mul,
        '/': operator.div,
	'^': operator.pow,
	'%': operator.mod,
    }
    
    stack = []

    splut = eval_str.split(' ')
    for atom in splut[::-1]:
        if atom in ops:
	    op1, op2 = [stack.pop(), stack.pop()]
            stack.append(ops[atom](op1, op2))
	else:
            stack.append(float(atom))

    return stack.pop()

def test_pow():
    assert calculate('^ 10 4') == 10000

def test_mod_neg1():
    assert calculate('% 10 -4') == -2

def test_mod_neg2():
    assert calculate('% -10 4') == 2

def test_div_by_zero():
    with pytest.raises(ZeroDivisionError):
        calculate('/ 1 0')

def test_add1():
    assert calculate('+ 3 4') == 7

def test_add2():
    assert calculate('+ 3 6') == 9

def test_mul():
    assert calculate('* 3 6') == 18

def test_sub():
    assert calculate('- 13 6') == 7

def test_div():
    assert calculate('/ 12 6') == 2

def test_complex1():
    assert calculate('+ / 12 6 4') == 6

def test_complex2():
    assert calculate('+ / 120 6 4') == 24 

def test_complex3():
    assert calculate('- / 120 6 4') == 16 

def test_floats():
    assert calculate('+ 0.1 0.2') == 0.30000000000000004

