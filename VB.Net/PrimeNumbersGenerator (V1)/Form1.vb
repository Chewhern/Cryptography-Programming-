Imports System.Text
Imports Org.BouncyCastle.Math
Imports Org.BouncyCastle.Security
Imports System.Threading
Imports System.IO
Public Class PrimeNumbersGeneratorForm
    Public thread1, thread2, thread3, thread4 As Thread
    Public timer1hour As Integer
    Public timer2hour As Integer
    Public timer3hour As Integer
    Public timer4hour As Integer
    Public CurrentRunningThreads As Integer
    Public SuspendedThreads As Integer
    Public PrimeCount As Integer
    Public PrimeList1 As New List(Of BigInteger)
    Public StringBuilder1 As New StringBuilder
    Public ResumeBigInteger As BigInteger
    Public StartingBitsString As String
    Public PublicStartingNumber As BigInteger
    Sub PrimeFunction384()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("24519928653854221733733552434404946937899825954937634817")
        EndingNumber = New BigInteger("6277101735386680763835789423207666416102355444464034512895")
        StartingBitsString = "384"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue384()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("6277101735386680763835789423207666416102355444464034512895")
        StartingBitsString = "384"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction512()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("452312848583266388373324160190187140051835877600158453279131187530910662657")
        EndingNumber = New BigInteger("115792089237316195423570985008687907853269984665640564039457584007913129639935")
        StartingBitsString = "512"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue512()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("115792089237316195423570985008687907853269984665640564039457584007913129639935")
        StartingBitsString = "512"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction768()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("153914086704665934422965000391185991426092731525255651046673021110334850669910978950836977558144201721900890587137")
        EndingNumber = New BigInteger("39402006196394479212279040100143613805079739270465446667948293404245721771497210611414266254884915640806627990306815")
        StartingBitsString = "768"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue768()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("39402006196394479212279040100143613805079739270465446667948293404245721771497210611414266254884915640806627990306815")
        StartingBitsString = "768"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction1024()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("52374249726338269920211035149241586435466272736689036631732661889538140742474792878132321477214466514414186946040961136147476104734166288853256441430017")
        EndingNumber = New BigInteger("13407807929942597099574024998205846127479365820592393377723561443721764030073546976801874298166903427690031858186486050853753882811946569946433649006084095")
        StartingBitsString = "1024"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue1024()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("13407807929942597099574024998205846127479365820592393377723561443721764030073546976801874298166903427690031858186486050853753882811946569946433649006084095")
        StartingBitsString = "1024"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction1280()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("17822033662586700072817076584766762987864173856439687228824970773044043621908896041038721919208482030385321521771853153557377752817872804680674458280164899172859354196719784961261227313463297")
        EndingNumber = New BigInteger("4562440617622195218641171605700291324893228507248559930579192517899275167208677386505912811317371399778642309573594407310688704721375437998252661319722214188251994674360264950082874192246603775")
        StartingBitsString = "1280"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue1280()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("4562440617622195218641171605700291324893228507248559930579192517899275167208677386505912811317371399778642309573594407310688704721375437998252661319722214188251994674360264950082874192246603775")
        StartingBitsString = "1280"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction1536()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("6064523798049644277925701126806650606472211004362096137261922023539261533931159712229993784486900304494092698035668254711607734547323493716579247168129613825017402250081444943555723771998431425098683590600454956058175183022718977")
        EndingNumber = New BigInteger("1552518092300708935148979488462502555256886017116696611139052038026050952686376886330878408828646477950487730697131073206171580044114814391444287275041181139204454976020849905550265285631598444825262999193716468750892846853816057855")
        StartingBitsString = "1536"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue1536()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("1552518092300708935148979488462502555256886017116696611139052038026050952686376886330878408828646477950487730697131073206171580044114814391444287275041181139204454976020849905550265285631598444825262999193716468750892846853816057855")
        StartingBitsString = "1536"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction1792()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("2063650512248692368563827284830142994214247367328599695812346519635444931862206482321942405811160890213571855442410658901884170154307365379884917884620857722298385484371113610034107490923540785363375909797699954703703235518560788042337487885808736236287260081631789057")
        EndingNumber = New BigInteger("528294531135665246352339784916516606518847326036121522127960709026673902556724859474417255887657187894674394993257128678882347559502685537250538978462939576908386683999005084168731517676426441053024232908211188404148028292751561738838396898767036476489538580897737998335")
        StartingBitsString = "1792"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue1792()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("528294531135665246352339784916516606518847326036121522127960709026673902556724859474417255887657187894674394993257128678882347559502685537250538978462939576908386683999005084168731517676426441053024232908211188404148028292751561738838396898767036476489538580897737998335")
        StartingBitsString = "1792"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction2048()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("702223880805592151456759840151962786569522257399338504974336254522393264865238137237142489540654437582500444843247630303354647534431314931612685275935445798350655833690880801860555545317367555154113605281582053784524026102900245630757473088050106395169337932361665227499793929447186391815763110662594625537")
        EndingNumber = New BigInteger("179769313486231590772930519078902473361797697894230657273430081157732675805500963132708477322407536021120113879871393357658789768814416622492847430639474124377767893424865485276302219601246094119453082952085005768838150682342462881473913110540827237163350510684586298239947245938479716304835356329624224137215")
        StartingBitsString = "2048"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue2048()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("179769313486231590772930519078902473361797697894230657273430081157732675805500963132708477322407536021120113879871393357658789768814416622492847430639474124377767893424865485276302219601246094119453082952085005768838150682342462881473913110540827237163350510684586298239947245938479716304835356329624224137215")
        StartingBitsString = "2048"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction2304()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("238954404268933865125126537965647370348186772435315621289825771761405069515984212194479937258429577313733767604974644713064293001386859963477865690977385256586189347544846179894960090613343571873484581297429015320656710070604819135113469266235546964237890007694823296373534385169983015617629084799101278271338071223315759934627648900036785340417")
        EndingNumber = New BigInteger("61172327492847069472032393719205726809135813743440799050195397570919697796091958321786863938157971792315844506873509046544459008355036150650333616890210625686064472971480622053109783197015954399612052812141827922088117778074833698589048132156300022844899841969874763871624802603515651998113045708569927237462546233168834543264678118409417047146495")
        StartingBitsString = "2304"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue2304()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("61172327492847069472032393719205726809135813743440799050195397570919697796091958321786863938157971792315844506873509046544459008355036150650333616890210625686064472971480622053109783197015954399612052812141827922088117778074833698589048132156300022844899841969874763871624802603515651998113045708569927237462546233168834543264678118409417047146495")
        StartingBitsString = "2304"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction2560()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("81311970270815617827540940057531918270431736306771131291555565237528187966198127328220620638533782694081418859017820373370184111315027069594843020356854068460344761792103283951352994919231121488069995473028826650091356852715222491148144542065923908529158975666493443972956379570533246911454881499147803139430220485962035320521081527255726234600609772419813960161833755551216431005697")
        EndingNumber = New BigInteger("20815864389328798163850480654728171077230524494533409610638224700807216119346720596024478883464648369684843227908562015582767132496646929816279813211354641525848259018778440691546366699323167100945918841095379622423387354295096957733925002768876520583464697770622321657076833170056511209332449663781837603694136444406281042053396870977465916057756101739472373801429441421111406337458175")
        StartingBitsString = "2560"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue2560()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("20815864389328798163850480654728171077230524494533409610638224700807216119346720596024478883464648369684843227908562015582767132496646929816279813211354641525848259018778440691546366699323167100945918841095379622423387354295096957733925002768876520583464697770622321657076833170056511209332449663781837603694136444406281042053396870977465916057756101739472373801429441421111406337458175")
        StartingBitsString = "2560"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction2616()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("1364188488619052116466105100188265419717379653273741532242786693992101715597506680981060248106739195555665885784215520253232226795300253192439713838619337787037991503054663889161182688006843079127591737170026798935139113651083474222050508981461091652957942433095504472118187338632823518614811421165606509195698926020610034372011417336379206274761103883598061489450479872973957125731659022336")
        EndingNumber = New BigInteger("349232253086477341815322905648195947447649191238077832254153393661978039192961710331151423515325234062250466760759173184827450059596864817264566742686550473481725824781993955625262768129751828256663484715526860527395613094677369400844930299254039463157233262872449144862255958690002820765391723818395266354098925061276168799234922838113076806338842594201103741299322847481333024187304709718015")
        StartingBitsString = "2616"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue2616()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("349232253086477341815322905648195947447649191238077832254153393661978039192961710331151423515325234062250466760759173184827450059596864817264566742686550473481725824781993955625262768129751828256663484715526860527395613094677369400844930299254039463157233262872449144862255958690002820765391723818395266354098925061276168799234922838113076806338842594201103741299322847481333024187304709718015")
        StartingBitsString = "2616"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction3072()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("9415282917660283549141080492298102003562864249787847466248730621348661685905481252613613375419320506497846743284718768702587566323417805956912550733948338482246927106959473534260867491865943358112677902880421172099989632257439840271333543445701202988272717348993362021990130294068818079733570952999163556134253785582896843527555593795167025195627264015042582006698797982330650903052793217987786621805705102527315773041820199267679075485942316354910174845075457")
        EndingNumber = New BigInteger("2410312426921032588580116606028314112912093247945688951359675039065257391591803200669085024107346049663448766280888004787862416978794958324969612987890774651455213339381625224770782077917681499676845543137387820057597345857904599109461387122099507964997815641342300677629473355281617428411794163967785870370368969109221591943054232011562758450080579587850900993714892283476646631181515063804873375182260506246992837898705971012525843324401232986857004760339316735")
        StartingBitsString = "3072"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue3072()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("2410312426921032588580116606028314112912093247945688951359675039065257391591803200669085024107346049663448766280888004787862416978794958324969612987890774651455213339381625224770782077917681499676845543137387820057597345857904599109461387122099507964997815641342300677629473355281617428411794163967785870370368969109221591943054232011562758450080579587850900993714892283476646631181515063804873375182260506246992837898705971012525843324401232986857004760339316735")
        StartingBitsString = "3072"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction3328()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("3203854756451720653595624251435681680620232578525492211861229828776304753379710936995444375946689500176660776461616679276667491760113792886668866710505209681612233972180610089418844744003656448715181017339055196355129384481767258658897707622287814270933417993576818863040102859294170662269079177235803761264367629793501945525087556647813406604969370763816323622827218446543817622830903894720044906793938477300747667387222787084891266524326010615181232478267868817481052360147556825740263526483623937")
        EndingNumber = New BigInteger("820186817651640487320479808367534510238779540102526006236474836166734016865205999870833760242352512045225158774173869894826877890589130978987229877889333678492731896878236182891224254464936050871086340438798130266913122427332418216677813151305680453358955006355665628938266331979307689540884269372365762883678113227136498054422414501840232090872158915536978847443767922315217311444711397048331496139248250188991402851129033493732164230227458717486395514436574417275149404197774547389507462779807727615")
        StartingBitsString = "3328"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue3328()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("820186817651640487320479808367534510238779540102526006236474836166734016865205999870833760242352512045225158774173869894826877890589130978987229877889333678492731896878236182891224254464936050871086340438798130266913122427332418216677813151305680453358955006355665628938266331979307689540884269372365762883678113227136498054422414501840232090872158915536978847443767922315217311444711397048331496139248250188991402851129033493732164230227458717486395514436574417275149404197774547389507462779807727615")
        StartingBitsString = "3328"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction3584()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("1090215279796298345343057319992441691038624747443985361781209060500115864369550760897269927218265076257224706224150656474098235960303036328065314058501678867531182833105052489870268422279120576700031813116210596361941430020414688522690787050244934600671795757515093047026287646566366777283893649942831776083163858446641848270013788759459916945946844663111358071639842481472666169361795887031940572252862030682746818684507336852618633070135215708762463263460541984102045620907003420426453486084172633338261276848631947315738747720031010817")
        EndingNumber = New BigInteger("279095111627852376407822673918065072905887935345660252615989519488029661278604994789701101367875859521849524793382568057369148405837577299984720398976429790087982805274893437406788716103454867635208144157749912668657006085226160261808841484862703257771979713923863820038729637520989894984676774385364934677289947762340313157123529922421738738162392233756507666339799675257002539356619747080176786496732679854783185583233878234270370065954615221443190595445898747930123678952192875629172092437548194134594886873249778512829119416327938768895")
        StartingBitsString = "3584"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue3584()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("279095111627852376407822673918065072905887935345660252615989519488029661278604994789701101367875859521849524793382568057369148405837577299984720398976429790087982805274893437406788716103454867635208144157749912668657006085226160261808841484862703257771979713923863820038729637520989894984676774385364934677289947762340313157123529922421738738162392233756507666339799675257002539356619747080176786496732679854783185583233878234270370065954615221443190595445898747930123678952192875629172092437548194134594886873249778512829119416327938768895")
        StartingBitsString = "3584"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction3840()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("370981035862457583615116655062050664026142463416738737276566235666348305807406382324631982063754316469425581439015546481957338970890854372164660306569997383113232275736063272571667870686084981815846130206637780398740082063211403756614358538728351214715427357315668316668341628979125496342934384997621515554501134755522154360113494980586766216631757522447684926047294728734518325208771563117872823305754323454924142963907913265357058823520949269451786277395565610597743231019172771450331484364942734257841383045472103658194839514758453221502007141603870695111736676880111108097")
        EndingNumber = New BigInteger("94971145180789141405469863695884969990692470634685116742800956330585166286696033875105787408321105016172948848387979899381078776548058719274153038481919330076987462588432197778346974895637755344856609332899271782077461008182119361693275785914457910967149403472811089067095457018656127063791202559391107981952290497413671516189054715030212151457729925746607341068107450556036691253445520158175442766273106804460580598760425795931407058821363012979657287013264796313022267140908229491284859997425339970007394059640858536497878915778164024704513828250590897948604589281308443672575")
        StartingBitsString = "3840"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue3840()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("94971145180789141405469863695884969990692470634685116742800956330585166286696033875105787408321105016172948848387979899381078776548058719274153038481919330076987462588432197778346974895637755344856609332899271782077461008182119361693275785914457910967149403472811089067095457018656127063791202559391107981952290497413671516189054715030212151457729925746607341068107450556036691253445520158175442766273106804460580598760425795931407058821363012979657287013264796313022267140908229491284859997425339970007394059640858536497878915778164024704513828250590897948604589281308443672575")
        StartingBitsString = "3840"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction4096()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("126238304966058622268417487065116999845484776053576109500509161826268184136202698801551568013761380717534054534851164138648904527931605160527688095259563605939964364716019515983399209962459578542172100149937763938581219604072733422507180056009672540900709554109516816573779593326332288314873251559077853068444977864803391962580800682760017849589281937637993445539366428356761821065267423102149447628375691862210717202025241630303118559188678304314076943801692528246980959705901641444238894928620825482303431806955690226308773426829503900930529395181208739591967195841536053143145775307050594328881077553168201547777")
        EndingNumber = New BigInteger("32317006071311007300714876688669951960444102669715484032130345427524655138867890893197201411522913463688717960921898019494119559150490921095088152386448283120630877367300996091750197750389652106796057638384067568276792218642619756161838094338476170470581645852036305042887575891541065808607552399123930385521914333389668342420684974786564569494856176035326322058077805659331026192708460314150258592864177116725943603718461857357598351152301645904403697613233287231227125684710820209725157101726931323469678542580656697935045997268352998638215525166389437335543602135433229604645318478604952148193555853611059596230655")
        StartingBitsString = "4096"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue4096()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("32317006071311007300714876688669951960444102669715484032130345427524655138867890893197201411522913463688717960921898019494119559150490921095088152386448283120630877367300996091750197750389652106796057638384067568276792218642619756161838094338476170470581645852036305042887575891541065808607552399123930385521914333389668342420684974786564569494856176035326322058077805659331026192708460314150258592864177116725943603718461857357598351152301645904403697613233287231227125684710820209725157101726931323469678542580656697935045997268352998638215525166389437335543602135433229604645318478604952148193555853611059596230655")
        StartingBitsString = "4096"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction15360()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("317780126850428784106525538104705354901244834087401002175105855775209590817123101435042332814353531956973312636295041844692182044037835775640391428267173700653216977911644557369868819000108941729784468906470020410628108305132067738229154928305709731920987918824593008953707405703616766260689916698288129509211700896556835362176096408621349176451673283483803329518100669752776943630557829994945655174116149534372212708119510568609233836048493637102030027768626840625047451339872387578315246457936374062997347438781528908612484241971396607904983726141764407145654061603118922755252117443046086136059447951781744701918208778844614086484557928804340771710499504357427054498721465863666440547154909493892274950343443774355016395612869876375928332596796146556805531312219643083219374877718849992509603949333281013619060122436657593019451527128822790175726936407871553663930960518005756690382464030034859459399593980708468105427261332891686052688287056151890201255507858509018530002047943118627181716560121891522788382034938101383427219248509545973382874570354680352497628751620715859596701686693505715767412614513531379509838756856352236731797558818063063141987380804007807860327578089321559068960788208839639909905740396488717312743780167339617345381996204896330475492781032869742786210995941939142971588231929566811261642007766472340856180508013405260998145868731851898399239076733411030786522081459079068487565315911844165079857374257537241628050768450763119145593428427860189999328688840910330375932935704917805464706140271343734893698116395169704880336076241412946999924888853118457669939495228238678553531397422998845817245163108614800571504836952579148548308984328319233859639210930490801698706995273948613242419469738451914925458978998388965647707037581893073290136889238129261057643794950592163120931095158745668871102467083600625191891953065065550472983127812757794722638071245615377512506436437529130334069656515462572803663695007064178294624917776788601133725100480483016941518897004552250040871204348440573575199875608587016778364232172491007481485160529868160485727511072874118244555985047490600338882791827738316309763820850393755784664960151564794869812525456000837695868007646177302232721594886100144393916027216376566090262451629142954759918091368631475548181511252750165061535737814347611107229697")
        EndingNumber = New BigInteger("81351712473709768731270537754804570854718677526374656556827099078453655249183513967370837200474504180985168034891530712241198603273685958563940205636396467367223546345381006686686417664027889082824824040056325225120795726113809340986663661646261691371772907219095810292149095860125892162736618674761761154358195429518549852717080680607065389171628360571853652356633771456710897569422804478706087724573734280799286453278594705563963862028414371098119687108768471200012147543007331220048703093231711760127320944328071400604795965944677531623675833892291688229287439770398444225344542065419798050831218675656126643691061447384221206140046829773911237557887873115501325951672695261098608780071656830436422387287921606234884197276894688352237653144779813518542216015928228629304159968696025598082458611029319939486479391343784343812979590944978634284986095720415117737966325892609473712737910791688924021606296059061367834989378901220271629488201486374883891521410011778308743680524273438368558519439391204229833825800944153954157368127618443769186015890010798170239392960414903260056755631793537463236457629315464033154518721755226172603340175057424144164348769485825998812243859990866319121653961781462947816935869541501111632062407722838942040417791028453460601726151944414654153270014961136420600726587373969103682980353988216919259182210051431746815525342395354085990205203643753223881349652853524241532816720873432106260443487809929533856780996723395358501271917677532208639828144343273044576238831540458958198964771909463996132786717797163444449366035517801714431980771546398325163504510778429101709704037740287704529214761755805388946305238259860262028367099988049723868067637998205645234868990790130844990059384253043690220917498623587575205813001620964626762275043644961090830756811507351593758958360360638891231002231573401760049124339984656780921083680720065995448995346238877536643201647728007457365521832067958418637737905921808429643423978950857881890233625723003652337028837633165376010463028313200786835251168155798276295261243436157697915260201095646249084346242834655774270606332172157593686753994707901008975299538137700801480874229798800587486672006516736214450142209957421389371576728290841636964842502967392400919107187617060596418539031390369657740334466880704042255753148880472988443450802175")
        StartingBitsString = "15360"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue15360()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("81351712473709768731270537754804570854718677526374656556827099078453655249183513967370837200474504180985168034891530712241198603273685958563940205636396467367223546345381006686686417664027889082824824040056325225120795726113809340986663661646261691371772907219095810292149095860125892162736618674761761154358195429518549852717080680607065389171628360571853652356633771456710897569422804478706087724573734280799286453278594705563963862028414371098119687108768471200012147543007331220048703093231711760127320944328071400604795965944677531623675833892291688229287439770398444225344542065419798050831218675656126643691061447384221206140046829773911237557887873115501325951672695261098608780071656830436422387287921606234884197276894688352237653144779813518542216015928228629304159968696025598082458611029319939486479391343784343812979590944978634284986095720415117737966325892609473712737910791688924021606296059061367834989378901220271629488201486374883891521410011778308743680524273438368558519439391204229833825800944153954157368127618443769186015890010798170239392960414903260056755631793537463236457629315464033154518721755226172603340175057424144164348769485825998812243859990866319121653961781462947816935869541501111632062407722838942040417791028453460601726151944414654153270014961136420600726587373969103682980353988216919259182210051431746815525342395354085990205203643753223881349652853524241532816720873432106260443487809929533856780996723395358501271917677532208639828144343273044576238831540458958198964771909463996132786717797163444449366035517801714431980771546398325163504510778429101709704037740287704529214761755805388946305238259860262028367099988049723868067637998205645234868990790130844990059384253043690220917498623587575205813001620964626762275043644961090830756811507351593758958360360638891231002231573401760049124339984656780921083680720065995448995346238877536643201647728007457365521832067958418637737905921808429643423978950857881890233625723003652337028837633165376010463028313200786835251168155798276295261243436157697915260201095646249084346242834655774270606332172157593686753994707901008975299538137700801480874229798800587486672006516736214450142209957421389371576728290841636964842502967392400919107187617060596418539031390369657740334466880704042255753148880472988443450802175")
        StartingBitsString = "15360"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunction16384()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = New BigInteger("4260734904763343474464782205991339306438531882797783954811846821053598952535622246938532166114070262593583171078738379973085432891317125248480389707334198433901977729852316365385194629797063301405065826615592336706140181807067674062973791226179243363351172861467968426562539373437603655612503536319554222470119146992951076773089864501424062557997757950365434554077847338878002719841187843967255920681054474244835254456308205531663751001712908507864556615491547059540653837667235332544991240309237887602991186415751083469043076671418145337897627975394319137376942413592515045847851550394379377014277539513911216763642638055100581900896668096821568381761048555553378790329672416543951665662172531271201654046860581725357211645263306231682286737834919667315927453778935528792943405737329531134336394616498502927572738163503930717234698073107063113541309130004011805902060800430768590470784680877470355661580346698910028605400231190482138217930751751711009871006894301065295357736073011044763046843599274385708635152802445549048764702173103623481885385267122533676398412648519056787795098971835608180603257639321543242528177872930686212156266135646468103548271248647769281551097572463198878780888096797089592271723010921270206852015519247968271592728750032047338120820331163080967819741459025366564772896869735201585782454517210710239022320460424711794849604404701771938667406932900050912052495255171971685232098371141722961756755091942862517868640996987123526470171661292460180696962324798857699373513232225116667219487381495374133410466379605832592376331100541335232667980446964026386543208159446517304998627707938199838929367326426625613732042937969828732843254327880771354849720167920737107227156371999463258605803491558377566645883737125914167269933433417778113621392758541495298025533014143580114652417601655366490388799907065144447616140493477769114471348318110097962307193626316189570513427700434761071747129838263300407318187221577927832918689911735811932635197165535233468849908616722804989338702023211804598009318119475953498016078515048980093650998843531144867542697644388127998163925540682024162913920916255849046202396968098784790269548000067661815658843604184896593786065462308097889117651264771180083828900842763229902722250348395236098982650487589326332473486870287795186134142042851687226653897767442650575149391531359434334725236011027250003185303166610368242826545511232163481043450055575260177357741333863635963189331838233054676509787755764514817")
        EndingNumber = New BigInteger("1090748135619415929462984244733782862448264161996232692431832786189721331849119295216264234525201987223957291796157025273109870820177184063610979765077554799078906298842192989538609825228048205159696851613591638196771886542609324560121290553901886301017900252535799917200010079600026535836800905297805880952350501630195475653911005312364560014847426035293551245843928918752768696279344088055617515694349945406677825140814900616105920256438504578013326493565836047242407382442812245131517757519164899226365743722432277368075027627883045206501792761700945699168497257879683851737049996900961120515655050115561271491492515342105748966629547032786321505730828430221664970324396138635251626409516168005427623435996308921691446181187406395310665404885739434832877428167407495370993511868756359970390117021823616749458620969857006263612082706715408157066575137281027022310927564910276759160520878304632411049364568754920967322982459184763427383790272448438018526977764941072715611580434690827459339991961414242741410599117426060556483763756314527611362658628383368621157993638020878537675545336789915694234433955666315070087213535470255670312004130725495834508357439653828936077080978550578912967907352780054935621561090795845172954115972927479877527738560008204118558930004777748727761853813510493840581861598652211605960308356405941821189714037868726219481498727603653616298856174822413033485438785324024751419417183012281078209729303537372804574372095228703622776363945290869806258422355148507571039619387449629866808188769662815778153079393179093143648340761738581819563002994422790754955061288818308430079648693232179158765918035565216157115402992120276155607873107937477466841528362987708699450152031231862594203085693838944657061346236704234026821102958954951197087076546186622796294536451620756509351018906023773821539532776208676978589731966330308893304665169436185078350641568336944530051437491311298834367265238595404904273455928723949525227184617404367854754610474377019768025576605881038077270707717942221977090385438585844095492116099852538903974655703943973086090930596963360767529964938414598185705963754561497355827813623833288906309004288017321424808663962671333528009232758350873059614118723781422101460198615747386855096896089189180441339558524822867541113212638793675567650340362970031930023397828465318547238244232028015189689660418822976000815437610652254270163595650875433851147123214227266605403581781469090806576468950587661997186505665475715792895")
        StartingBitsString = "16384"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub PrimeFunctionContinue16384()
        Dim StartingNumber, EndingNumber, x As BigInteger
        Dim StopLoopInteger As Integer = 0
        Dim Random1 As New SecureRandom
        Timer1.Enabled = True
        Timer1.Start()
        StartingNumber = ResumeBigInteger
        EndingNumber = New BigInteger("1090748135619415929462984244733782862448264161996232692431832786189721331849119295216264234525201987223957291796157025273109870820177184063610979765077554799078906298842192989538609825228048205159696851613591638196771886542609324560121290553901886301017900252535799917200010079600026535836800905297805880952350501630195475653911005312364560014847426035293551245843928918752768696279344088055617515694349945406677825140814900616105920256438504578013326493565836047242407382442812245131517757519164899226365743722432277368075027627883045206501792761700945699168497257879683851737049996900961120515655050115561271491492515342105748966629547032786321505730828430221664970324396138635251626409516168005427623435996308921691446181187406395310665404885739434832877428167407495370993511868756359970390117021823616749458620969857006263612082706715408157066575137281027022310927564910276759160520878304632411049364568754920967322982459184763427383790272448438018526977764941072715611580434690827459339991961414242741410599117426060556483763756314527611362658628383368621157993638020878537675545336789915694234433955666315070087213535470255670312004130725495834508357439653828936077080978550578912967907352780054935621561090795845172954115972927479877527738560008204118558930004777748727761853813510493840581861598652211605960308356405941821189714037868726219481498727603653616298856174822413033485438785324024751419417183012281078209729303537372804574372095228703622776363945290869806258422355148507571039619387449629866808188769662815778153079393179093143648340761738581819563002994422790754955061288818308430079648693232179158765918035565216157115402992120276155607873107937477466841528362987708699450152031231862594203085693838944657061346236704234026821102958954951197087076546186622796294536451620756509351018906023773821539532776208676978589731966330308893304665169436185078350641568336944530051437491311298834367265238595404904273455928723949525227184617404367854754610474377019768025576605881038077270707717942221977090385438585844095492116099852538903974655703943973086090930596963360767529964938414598185705963754561497355827813623833288906309004288017321424808663962671333528009232758350873059614118723781422101460198615747386855096896089189180441339558524822867541113212638793675567650340362970031930023397828465318547238244232028015189689660418822976000815437610652254270163595650875433851147123214227266605403581781469090806576468950587661997186505665475715792895")
        StartingBitsString = "16384"
        SNumberRTB.Text = StartingNumber.ToString
        ENumberRTB.Text = EndingNumber.ToString
        x = StartingNumber
        While x.CompareTo(EndingNumber) < 0 Or x.CompareTo(EndingNumber) = 0
            If x.IsProbablePrime(1) = True Then
                PrimeCount += 1
                PrimeList1.Add(x)
                StringBuilder1.Append(x.ToString + vbNewLine)
                PrimeListCountRTB.Text = PrimeCount.ToString
            End If
            CNumberRTB.Text = x.ToString
            PrimeListCountRTB.Refresh()
            CNumberRTB.Refresh()
            x = x.Add(New BigInteger("2"))
        End While
        ExportListOfPrimes(StringBuilder1.ToString)
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        PList1GSRTB1.Text = "Completed"
        MessageBox.Show("1st Prime List generation has been completed")
    End Sub

    Sub SetPublicStartingNumber(ByVal Selection As Integer)
        Dim SetStartingNumber As BigInteger
        If Selection >= 1 And Selection <= 18 Then
            If Selection = 1 Then
                '384
                SetStartingNumber = New BigInteger("24519928653854221733733552434404946937899825954937634817")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 2 Then
                '512
                SetStartingNumber = New BigInteger("452312848583266388373324160190187140051835877600158453279131187530910662657")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 3 Then
                '768
                SetStartingNumber = New BigInteger("153914086704665934422965000391185991426092731525255651046673021110334850669910978950836977558144201721900890587137")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 4 Then
                '1024
                SetStartingNumber = New BigInteger("52374249726338269920211035149241586435466272736689036631732661889538140742474792878132321477214466514414186946040961136147476104734166288853256441430017")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 5 Then
                '1280
                SetStartingNumber = New BigInteger("17822033662586700072817076584766762987864173856439687228824970773044043621908896041038721919208482030385321521771853153557377752817872804680674458280164899172859354196719784961261227313463297")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 6 Then
                '1536
                SetStartingNumber = New BigInteger("6064523798049644277925701126806650606472211004362096137261922023539261533931159712229993784486900304494092698035668254711607734547323493716579247168129613825017402250081444943555723771998431425098683590600454956058175183022718977")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 7 Then
                '1792
                SetStartingNumber = New BigInteger("2063650512248692368563827284830142994214247367328599695812346519635444931862206482321942405811160890213571855442410658901884170154307365379884917884620857722298385484371113610034107490923540785363375909797699954703703235518560788042337487885808736236287260081631789057")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 8 Then
                '2048
                SetStartingNumber = New BigInteger("702223880805592151456759840151962786569522257399338504974336254522393264865238137237142489540654437582500444843247630303354647534431314931612685275935445798350655833690880801860555545317367555154113605281582053784524026102900245630757473088050106395169337932361665227499793929447186391815763110662594625537")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 9 Then
                '2304
                SetStartingNumber = New BigInteger("238954404268933865125126537965647370348186772435315621289825771761405069515984212194479937258429577313733767604974644713064293001386859963477865690977385256586189347544846179894960090613343571873484581297429015320656710070604819135113469266235546964237890007694823296373534385169983015617629084799101278271338071223315759934627648900036785340417")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 10 Then
                '2560
                SetStartingNumber = New BigInteger("81311970270815617827540940057531918270431736306771131291555565237528187966198127328220620638533782694081418859017820373370184111315027069594843020356854068460344761792103283951352994919231121488069995473028826650091356852715222491148144542065923908529158975666493443972956379570533246911454881499147803139430220485962035320521081527255726234600609772419813960161833755551216431005697")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 11 Then
                '2616
                SetStartingNumber = New BigInteger("1364188488619052116466105100188265419717379653273741532242786693992101715597506680981060248106739195555665885784215520253232226795300253192439713838619337787037991503054663889161182688006843079127591737170026798935139113651083474222050508981461091652957942433095504472118187338632823518614811421165606509195698926020610034372011417336379206274761103883598061489450479872973957125731659022336")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 12 Then
                '3072
                SetStartingNumber = New BigInteger("9415282917660283549141080492298102003562864249787847466248730621348661685905481252613613375419320506497846743284718768702587566323417805956912550733948338482246927106959473534260867491865943358112677902880421172099989632257439840271333543445701202988272717348993362021990130294068818079733570952999163556134253785582896843527555593795167025195627264015042582006698797982330650903052793217987786621805705102527315773041820199267679075485942316354910174845075457")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 13 Then
                '3328
                SetStartingNumber = New BigInteger("3203854756451720653595624251435681680620232578525492211861229828776304753379710936995444375946689500176660776461616679276667491760113792886668866710505209681612233972180610089418844744003656448715181017339055196355129384481767258658897707622287814270933417993576818863040102859294170662269079177235803761264367629793501945525087556647813406604969370763816323622827218446543817622830903894720044906793938477300747667387222787084891266524326010615181232478267868817481052360147556825740263526483623937")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 14 Then
                '3584
                SetStartingNumber = New BigInteger("1090215279796298345343057319992441691038624747443985361781209060500115864369550760897269927218265076257224706224150656474098235960303036328065314058501678867531182833105052489870268422279120576700031813116210596361941430020414688522690787050244934600671795757515093047026287646566366777283893649942831776083163858446641848270013788759459916945946844663111358071639842481472666169361795887031940572252862030682746818684507336852618633070135215708762463263460541984102045620907003420426453486084172633338261276848631947315738747720031010817")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 15 Then
                '3840
                SetStartingNumber = New BigInteger("370981035862457583615116655062050664026142463416738737276566235666348305807406382324631982063754316469425581439015546481957338970890854372164660306569997383113232275736063272571667870686084981815846130206637780398740082063211403756614358538728351214715427357315668316668341628979125496342934384997621515554501134755522154360113494980586766216631757522447684926047294728734518325208771563117872823305754323454924142963907913265357058823520949269451786277395565610597743231019172771450331484364942734257841383045472103658194839514758453221502007141603870695111736676880111108097")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 16 Then
                '4096
                SetStartingNumber = New BigInteger("126238304966058622268417487065116999845484776053576109500509161826268184136202698801551568013761380717534054534851164138648904527931605160527688095259563605939964364716019515983399209962459578542172100149937763938581219604072733422507180056009672540900709554109516816573779593326332288314873251559077853068444977864803391962580800682760017849589281937637993445539366428356761821065267423102149447628375691862210717202025241630303118559188678304314076943801692528246980959705901641444238894928620825482303431806955690226308773426829503900930529395181208739591967195841536053143145775307050594328881077553168201547777")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 17 Then
                '15360
                SetStartingNumber = New BigInteger("317780126850428784106525538104705354901244834087401002175105855775209590817123101435042332814353531956973312636295041844692182044037835775640391428267173700653216977911644557369868819000108941729784468906470020410628108305132067738229154928305709731920987918824593008953707405703616766260689916698288129509211700896556835362176096408621349176451673283483803329518100669752776943630557829994945655174116149534372212708119510568609233836048493637102030027768626840625047451339872387578315246457936374062997347438781528908612484241971396607904983726141764407145654061603118922755252117443046086136059447951781744701918208778844614086484557928804340771710499504357427054498721465863666440547154909493892274950343443774355016395612869876375928332596796146556805531312219643083219374877718849992509603949333281013619060122436657593019451527128822790175726936407871553663930960518005756690382464030034859459399593980708468105427261332891686052688287056151890201255507858509018530002047943118627181716560121891522788382034938101383427219248509545973382874570354680352497628751620715859596701686693505715767412614513531379509838756856352236731797558818063063141987380804007807860327578089321559068960788208839639909905740396488717312743780167339617345381996204896330475492781032869742786210995941939142971588231929566811261642007766472340856180508013405260998145868731851898399239076733411030786522081459079068487565315911844165079857374257537241628050768450763119145593428427860189999328688840910330375932935704917805464706140271343734893698116395169704880336076241412946999924888853118457669939495228238678553531397422998845817245163108614800571504836952579148548308984328319233859639210930490801698706995273948613242419469738451914925458978998388965647707037581893073290136889238129261057643794950592163120931095158745668871102467083600625191891953065065550472983127812757794722638071245615377512506436437529130334069656515462572803663695007064178294624917776788601133725100480483016941518897004552250040871204348440573575199875608587016778364232172491007481485160529868160485727511072874118244555985047490600338882791827738316309763820850393755784664960151564794869812525456000837695868007646177302232721594886100144393916027216376566090262451629142954759918091368631475548181511252750165061535737814347611107229697")
                PublicStartingNumber = SetStartingNumber
            ElseIf Selection = 18 Then
                '16384
                SetStartingNumber = New BigInteger("4260734904763343474464782205991339306438531882797783954811846821053598952535622246938532166114070262593583171078738379973085432891317125248480389707334198433901977729852316365385194629797063301405065826615592336706140181807067674062973791226179243363351172861467968426562539373437603655612503536319554222470119146992951076773089864501424062557997757950365434554077847338878002719841187843967255920681054474244835254456308205531663751001712908507864556615491547059540653837667235332544991240309237887602991186415751083469043076671418145337897627975394319137376942413592515045847851550394379377014277539513911216763642638055100581900896668096821568381761048555553378790329672416543951665662172531271201654046860581725357211645263306231682286737834919667315927453778935528792943405737329531134336394616498502927572738163503930717234698073107063113541309130004011805902060800430768590470784680877470355661580346698910028605400231190482138217930751751711009871006894301065295357736073011044763046843599274385708635152802445549048764702173103623481885385267122533676398412648519056787795098971835608180603257639321543242528177872930686212156266135646468103548271248647769281551097572463198878780888096797089592271723010921270206852015519247968271592728750032047338120820331163080967819741459025366564772896869735201585782454517210710239022320460424711794849604404701771938667406932900050912052495255171971685232098371141722961756755091942862517868640996987123526470171661292460180696962324798857699373513232225116667219487381495374133410466379605832592376331100541335232667980446964026386543208159446517304998627707938199838929367326426625613732042937969828732843254327880771354849720167920737107227156371999463258605803491558377566645883737125914167269933433417778113621392758541495298025533014143580114652417601655366490388799907065144447616140493477769114471348318110097962307193626316189570513427700434761071747129838263300407318187221577927832918689911735811932635197165535233468849908616722804989338702023211804598009318119475953498016078515048980093650998843531144867542697644388127998163925540682024162913920916255849046202396968098784790269548000067661815658843604184896593786065462308097889117651264771180083828900842763229902722250348395236098982650487589326332473486870287795186134142042851687226653897767442650575149391531359434334725236011027250003185303166610368242826545511232163481043450055575260177357741333863635963189331838233054676509787755764514817")
                PublicStartingNumber = SetStartingNumber
            End If
        End If
    End Sub

    Private Sub GenerateBTN_Click(sender As Object, e As EventArgs) Handles GenerateBTN.Click
        Dim GenerateResumeBigInteger As BigInteger
        Dim RemainderBigInteger As BigInteger
        If SNumberRTB.Text <> "" Then
            GenerateResumeBigInteger = New BigInteger(SNumberRTB.Text)
        Else
            GenerateResumeBigInteger = New BigInteger("0")
        End If
        If BitsCB.Text <> "" Then

            If BitsCB.Text = "384" Then
                SetPublicStartingNumber(1)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 384 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue384)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction384)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "512" Then
                SetPublicStartingNumber(2)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 512 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue512)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction512)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "768" Then
                SetPublicStartingNumber(3)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 768 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue768)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction768)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "1024" Then
                SetPublicStartingNumber(4)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 1024 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue1024)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction1024)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "1280" Then
                SetPublicStartingNumber(5)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 1280 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue1280)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction1280)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "1536" Then
                SetPublicStartingNumber(6)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 1536 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue1536)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction1536)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "1792" Then
                SetPublicStartingNumber(7)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 1792 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue1792)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction1792)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "2048" Then
                SetPublicStartingNumber(8)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 2048 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue2048)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction2048)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "2304" Then
                SetPublicStartingNumber(9)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 2304 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue2304)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction2304)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "2560" Then
                SetPublicStartingNumber(10)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 2560 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue2560)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction2560)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "2616" Then
                SetPublicStartingNumber(11)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 2616 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue2616)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction2616)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "3072" Then
                SetPublicStartingNumber(12)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 3072 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue3072)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction3072)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "3328" Then
                SetPublicStartingNumber(13)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 3328 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue3328)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction3328)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "3584" Then
                SetPublicStartingNumber(14)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 3584 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue3584)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction3584)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "3840" Then
                SetPublicStartingNumber(15)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 3840 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue3840)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction3840)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "4096" Then
                SetPublicStartingNumber(16)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 4096 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue4096)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction4096)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "15360" Then
                SetPublicStartingNumber(17)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 15360 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue15360)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction15360)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            ElseIf BitsCB.Text = "16384" Then
                SetPublicStartingNumber(18)
                If GenerateResumeBigInteger.CompareTo(New BigInteger("0")) <> 0 Then
                    If PublicStartingNumber.CompareTo(GenerateResumeBigInteger) > 0 Then
                        MessageBox.Show("Please enter a number bigger than the initial 16384 bits number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        RemainderBigInteger = GenerateResumeBigInteger.Mod(New BigInteger("2"))
                        If RemainderBigInteger.CompareTo(New BigInteger("0")) = 0 Then
                            MessageBox.Show("Please enter an odd number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ResumeBigInteger = GenerateResumeBigInteger
                            thread1 = New Thread(AddressOf PrimeFunctionContinue16384)
                            thread1.Start()
                            GenerateBTN.Enabled = False
                        End If
                    End If
                Else
                    thread1 = New Thread(AddressOf PrimeFunction16384)
                    thread1.Start()
                    GenerateBTN.Enabled = False
                End If
            End If
        Else
            MessageBox.Show("Please select any number of bits", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        CurrentRunningThreads = 1
        CRThreadsRTB.Text = CurrentRunningThreads.ToString
    End Sub

    Private Sub PrimeNumbersGeneratorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer1hour = 0
        timer2hour = 0
        timer3hour = 0
        timer4hour = 0
        CheckForIllegalCrossThreadCalls = False
        CurrentRunningThreads = 0
        SuspendedThreads = 0
        PrimeCount = 0
    End Sub

    Sub ExportListOfPrimes(ByVal Value As String)
        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter("D:\IncompletePrimeList" & StartingBitsString & ".txt")
        objStreamWriter.WriteLine(Value)
        objStreamWriter.Close()
    End Sub

    Private Sub AbortBTN_Click(sender As Object, e As EventArgs) Handles AbortBTN.Click
        thread1.Abort()
        GenerateBTN.Enabled = True
    End Sub

    Private Sub ExportBTN_Click(sender As Object, e As EventArgs) Handles ExportBTN.Click
        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter("D:\IncompletePrimeList" & StartingBitsString & ".txt")
        objStreamWriter.WriteLine(StringBuilder1.ToString)
        objStreamWriter.Close()
    End Sub

    Private Sub CheckResultBTN_Click(sender As Object, e As EventArgs) Handles CheckResultBTN.Click
        MessageBox.Show(StringBuilder1.ToString, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ReadMeBTN_Click(sender As Object, e As EventArgs) Handles ReadMeBTN.Click
        MessageBox.Show("The number of bits that you can select to generate prime numbers need to be divided by 2 because the Public/Private Key Generation in RSA nowadays is using CRT for code efficiency. For example, 384 bits is actually means that the public/private key generated is by using 2 prime numbers of 192 bits. The same thing goes for other bits.", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("If you wished to resume where you started, you will need to type in an odd number that is bigger than the starting number", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer1hour += 1
        Timer1RTB.Text = timer1hour.ToString
    End Sub

    <Obsolete>
    Private Sub PauseAllBTN_Click(sender As Object, e As EventArgs) Handles PauseAllBTN.Click
        thread1.Suspend()
    End Sub

    <Obsolete>
    Private Sub ResumeBTN_Click(sender As Object, e As EventArgs) Handles ResumeBTN.Click
        thread1.Resume()
    End Sub
End Class
