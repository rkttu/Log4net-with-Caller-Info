Log4net-with-Caller-Info
========================

I'm sorry. Currently, the English version of the article did not write. Wait for the participants.

이 라이브러리는 log4net에 C# 5.0의 호출자 정보를 더하여 좀 더 정밀하게 로그를 기록할 수 있도록 도와주는 도우미 라이브러리입니다.

* GitHub 프로젝트 페이지: https://github.com/rkttu/Log4net-with-Caller-Info
* NuGet 패키지 페이지: http://www.nuget.org/packages/log4net-callerinfo/

# 설치와 사용

이 패키지의 사용 방법은 단순합니다. 패키지 관리자 콘솔에서 다음과 같이 명령어를 입력하시면 됩니다. 또는 NuGet 패키지 검색 대화 상자에서 log4net callerinfo 로 검색하시면 쉽게 찾을 수 있습니다.

~~~
PM> Install-Package log4net-callerinfo
~~~

자동으로 log4net 종속성에 따라 log4net NuGet 패키지도 설치가 될 것입니다. 설치가 되고 난 다음에는, Log4net 구성 방법에 따라 로그 기록이 이루어질 수 있도록 구성해주시고, 로그를 기록할 코드에서 ClouDeveloper.Log4net.CallerInfo 네임스페이스를 참조합니다.

~~~
using ClouDeveloper.Log4net.CallerInfo;
~~~

그 후 ObtainLog() 확장 메서드를 사용하여 로그 기록과 연관된 객체에 대한 CallerInfoLog 객체의 참조를 얻고, 종전에 log4net을 사용할 때와 동일하게 로그 기록을 하시면 됩니다.

~~~
var log = this.ObtainLog();
log.Warn("Hello!");
log.WarnFormat("Today is {0:yyyy-MM-dd}.", DateTime.UtcNow);
log.WarnFormat(CultureInfo.GetCulture("en-US"), "{0:C} {1:C} {2:C}", 1, 2, 3);
~~~

호출자 정보 기록 기능에 의하여, 코드는 위와 같이 평소에 log4net을 사용할 때와 다르지 않지만, 실제 로그는 다음과 같이 기록됩니다.

~~~
[Main, Program.cs:16] Hello!
[Main, Program.cs:17] Today is 2014-11-29
[Main, Program.cs:18] $1.00 $2.00 $3.00
~~~

위의 방법을 사용하여 코드를 기록할 때 얻을 수 있는 부수적인 이점으로, Stack Trace를 표시하는 방식보다 더 직관적이고 개발자에게 유용한 관점에서 로그를 기록하기 때문에, Async/Await 패턴의 코드에서도 복잡하지 않고 정확하며 유용한 로그를 기록할 수 있습니다.

# 두 가지 메모

편의를 위하여 Format 시리즈 메서드는 원래의 ILog 인터페이스와는 무관하게 최대 16개의 인자를 받을 수 있도록 구성하였습니다. 16개를 넘는 경우, new object[] { … } 식을 사용하여 매개 변수 목록을 전달하는 대체 방안을 불가피하게 사용하셔야 하는데, 나중에 라이브러리를 업그레이드하면서는 필요에 따라 적어도 32개까지 인수를 늘려야 하지 않을까 고민하고 있습니다.

사용하는 코드의 모습이 다르지는 않지만, 실제로는 메서드 시그니처들이 다른 관계로, 위의 CallerInfoLog 클래스는 ILog 인터페이스를 구현하고 있지 않습니다. 대신, 내부에 포함하고 있는 ILog 객체를 UnderlyingLogObject 속성을 통하여 참조를 가져올 수 있고, ILog 인터페이스가 제공하는 멤버들과 동일한 이름과 호출 문법을 사용할 수 있도록 구성하였습니다.

# 피드백을 환영합니다.

GitHub에 코드를 제안해주셔도 좋고, 버그 리포트 등을 남겨주셔도 좋습니다. 언제든지 피드백을 환영합니다.
