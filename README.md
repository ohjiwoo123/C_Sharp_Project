# C_Sharp_Project
C# Language

## C# 언어 특징
C#은 전역의 개념이 없다.(함수들이 Class내의 static 함수이거나, 멤버함수이다.  

예를 들어서  
```
class xxx{
static int a; // 클래스의 변수
int b;  // 인스턴스의 변수

static int x()  // 클래스의 함수
int y()  // 인스턴스의 함수
}
```

`<Console.WriteLine()>`  
`<System.Array.Sort(배열)>`  
여기서 WriteLine 함수와 Sort함수 같은 경우가 static 함수인 것이다.  
인스턴스 함수는 우리가 
```
class xxx{
static int a; // 클래스의 변수
int b;  // 인스턴스의 변수

static int x()  // 클래스의 함수
int y()  // 인스턴스의 함수
}
xxx InstanceObject;
InstanceObject.b;  
InstanceObject.y(); 
```
위와 같은 방식으로 객체를 선언 한 후에 사용하는 것이 인스턴스 함수이다.  

Python의 경우 전역함수, static함수, class 함수를 사용한다고 한다.  
