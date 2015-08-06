def add(vals):
    return sum(vals)

def substrct(vals):
    start = vals[0]
    for v in vals[1:]:
        start -= v
    return start

def divide(vals):
    start = vals[0]
    for v in vals[1:]:
        start /= v
    return start

def multiply(vals):
    start = vals[0]
    for v in vals[1:]:
        start *= v
    return start

operationMap = {"+" : add, 
                "-" : substrct,
                "/" : divide,
                "*" : multiply}

def evaluate(expression):
    exp_list = expression.split(" ") 
    op = exp_list[0] 
    args = map(int, exp_list[1:]) 
    return operationMap[op](args)

pattern = re.compile('\[(.*)\[(.*)\]\]')
## recursively re.search expression until no more groups, then work backwards through groups evaluating

#### * Last problem

expression = "[+ [- 4 2 [* 10 [- 5 2]]] [+ 1 3]]"

while 2 > 1: 
    pClose = expression.find("]") + 1 
    if pClose == -1:
        break 
    pOpen = expression.rfind("[", 0, pClose)
    expSubGroup = expression[pOpen : pClose]
    res = evaluate(expSubGroup[1:-1]) 
    expression = expression.replace(expSubGroup, 
                                    str(res), 
                                    1) 
