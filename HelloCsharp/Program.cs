using System;
// using 특정한 키워드를 가진 네임
// 시스템이라는 보따리 안에 많은 툴이 들어가있음
using System.Collections.Generic;
// 시스템안 컬렉션안에 제너릭이라는 보따리가 있음
using System.Linq;
// 시스템안 링크 보따리가 있음
using System.Text;
// 시스템안에 텍스트 보따리가 있음
using System.Threading.Tasks;
// 시스템이라는 큰 보따리안에 스레딩이라는게 있고 그 안에 테스크스라는게 있음

namespace HelloCsharp
    // 네임스페이스는 보따리를 만드는거다
    // 헬로 시샵이라는 보따리로 지정해줌
    // 헬로시샵은 내 보따리다
{
    internal class Program
        // 그 안에 프로그램이라는 툴을 집어넣음

    {
        // 메인이라는 기능은 이걸 함수라고 한다
        // 메인함수는 실행할때 먼저 실행되는 기능이다.
        // 메인은 딱 하나이다
        // 스트링이라는 배열을 args로 받아들인다
        // string[] args 를 말하는 명칭을 인자라고 한다
        // 스트링은 말 그대로 문자열이다
        static void Main(string[] args)
        {
            Console.WriteLine("hello c#");
               // write으 바로 옆에 적지만 WriteLine을 쓰면 바로 아랫줄로 넘어간다
            Console.WriteLine("헬로우 ");
              // 콘솔이라는 도화지에 헬로 시샵을 적어라
            Console.ReadKey();
                // 키를 읽어라 라는 뜻 여기서 실행을 시키면 키를 받기위해 기다림. 아무키나 입력받으면 꺼짐
           
        }
    }
}
