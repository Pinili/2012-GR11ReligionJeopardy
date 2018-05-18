Public Class MainWindow_Form

    'Creates a list array of buttons, in this case, the "points" buttons
    Private lbtnJeoButtons As New List(Of Button)

    'Stored Questions, Answers, and Points
    '--0 is for the Question
    '--1 is for possible Answers (MC only)
    '--2 is for the Answer (Give the letter in MC and True or False in True False Questions)
    '--3 is for the Type of Answer (Multiple Choice, True False, Short Answer)
    '--4 is for the Points Earned
    Public astrAboriginal(14, 5) As String
    Public astrSikkhism(14, 5) As String
    Public astrHinduism(14, 5) As String
    Public astrBuddhism(14, 5) As String
    Public astrJudaism(14, 5) As String
    Public astrChristian(14, 5) As String
    Public astrIslam(14, 5) As String

    'Current Question, Answer, and Points
    Public strQuestion As String
    Public strPossAnswer As String
    Public strAnswer As String
    Public strTypeAnswer As String
    Public intPoints As Integer
    Public strReligion As String

    'Counts the double daily
    Dim intDailyDouble As Integer = 0

    'Checks if it has reached double jeopardy
    Dim intJeopardyGameUsage As Integer

    'If true, it is the double jeopardy round
    Dim blnDoubleJeo As Boolean

    'This keeps track of the Final Jeo Round
    Public astrTeamAns(5) As String
    Public aintTeamWagers(5) As Integer

    'Keeps track of the teams and their scores
    Public intNumOfTeams As Integer
    Public aintTeamScores(5) As Integer

    'Keeps track of who is answering the current question and if the first team to answer got it right
    Public intCurTeam As Integer
    Public intLeadingTeam As Integer = 5

    'Keeps track of the timer and how long for the question to end
    Public blnTimerEnabled As Boolean
    Public intTimerSeconds As Integer



    Private Sub MainWindow_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Randomize integers and start randomizing
        Randomize()

        'Declaring all buttons to a 2d-array
        lbtnJeoButtons.Add(Aboriginal1_Button)
        lbtnJeoButtons.Add(Aboriginal2_Button)
        lbtnJeoButtons.Add(Aboriginal3_Button)
        lbtnJeoButtons.Add(Aboriginal4_Button)
        lbtnJeoButtons.Add(Aboriginal5_Button)
        lbtnJeoButtons.Add(Aboriginal6_Button)
        lbtnJeoButtons.Add(Aboriginal7_Button)
        lbtnJeoButtons.Add(Sikkhism1_Button)
        lbtnJeoButtons.Add(Sikkhism2_Button)
        lbtnJeoButtons.Add(Sikkhism3_Button)
        lbtnJeoButtons.Add(Sikkhism4_Button)
        lbtnJeoButtons.Add(Sikkhism5_Button)
        lbtnJeoButtons.Add(Sikkhism6_Button)
        lbtnJeoButtons.Add(Sikkhism7_Button)
        lbtnJeoButtons.Add(Hinduism1_Button)
        lbtnJeoButtons.Add(Hinduism2_Button)
        lbtnJeoButtons.Add(Hinduism3_Button)
        lbtnJeoButtons.Add(Hinduism4_Button)
        lbtnJeoButtons.Add(Hinduism5_Button)
        lbtnJeoButtons.Add(Hinduism6_Button)
        lbtnJeoButtons.Add(Hinduism7_Button)
        lbtnJeoButtons.Add(Buddhism1_Button)
        lbtnJeoButtons.Add(Buddhism2_Button)
        lbtnJeoButtons.Add(Buddhism3_Button)
        lbtnJeoButtons.Add(Buddhism4_Button)
        lbtnJeoButtons.Add(Buddhism5_Button)
        lbtnJeoButtons.Add(Buddhism6_Button)
        lbtnJeoButtons.Add(Buddhism7_Button)
        lbtnJeoButtons.Add(Judaism1_Button)
        lbtnJeoButtons.Add(Judaism2_Button)
        lbtnJeoButtons.Add(Judaism3_Button)
        lbtnJeoButtons.Add(Judaism4_Button)
        lbtnJeoButtons.Add(Judaism5_Button)
        lbtnJeoButtons.Add(Judaism6_Button)
        lbtnJeoButtons.Add(Judaism7_Button)
        lbtnJeoButtons.Add(Christian1_Button)
        lbtnJeoButtons.Add(Christian2_Button)
        lbtnJeoButtons.Add(Christian3_Button)
        lbtnJeoButtons.Add(Christian4_Button)
        lbtnJeoButtons.Add(Christian5_Button)
        lbtnJeoButtons.Add(Christian6_Button)
        lbtnJeoButtons.Add(Christian7_Button)
        lbtnJeoButtons.Add(Islam1_Button)
        lbtnJeoButtons.Add(Islam2_Button)
        lbtnJeoButtons.Add(Islam3_Button)
        lbtnJeoButtons.Add(Islam4_Button)
        lbtnJeoButtons.Add(Islam5_Button)
        lbtnJeoButtons.Add(Islam6_Button)
        lbtnJeoButtons.Add(Islam7_Button)


        '-------------JEOPARDY ROUND 1 QUESTIONS

        'The Aboriginal Questions
        astrAboriginal(0, 0) = "Which country/continent did Aboriginals began?"
        astrAboriginal(0, 1) = "Mexico|South America |India|North America"
        astrAboriginal(0, 2) = "D"
        astrAboriginal(0, 3) = "MC"
        astrAboriginal(0, 4) = "100"

        astrAboriginal(1, 0) = "The tribal people beilieved in ownership,taking care of their individual possessions."
        astrAboriginal(1, 2) = "B"
        astrAboriginal(1, 3) = "TrueFalse"
        astrAboriginal(1, 4) = "200"

        astrAboriginal(2, 0) = "What was the word used to describe all of the nateral events in the world?"
        astrAboriginal(2, 1) = "ceremony|wonders|mana|experience"
        astrAboriginal(2, 2) = "C"
        astrAboriginal(2, 3) = "MC"
        astrAboriginal(2, 4) = "300"

        astrAboriginal(3, 0) = "Every object has a spirit or soul which is called _________."
        astrAboriginal(3, 1) = "animism|essence|exorcism|spiritualism"
        astrAboriginal(3, 2) = "A"
        astrAboriginal(3, 3) = "MC"
        astrAboriginal(3, 4) = "400"

        astrAboriginal(4, 0) = "Which object symbolizes the ancestors of a tribe or brother kin-sister kin?"
        astrAboriginal(4, 1) = "animals|totem pole|necklace|tabooed objects"
        astrAboriginal(4, 2) = "B"
        astrAboriginal(4, 3) = "MC"
        astrAboriginal(4, 4) = "500"

        astrAboriginal(5, 0) = "Which is not part of Aboriginal Culture?"
        astrAboriginal(5, 1) = "praying for rain, sun, crops, and etc.|worshiping one God|cave art and drawings|carving totem poles"
        astrAboriginal(5, 2) = "B"
        astrAboriginal(5, 3) = "MC"
        astrAboriginal(5, 4) = "800"

        astrAboriginal(6, 0) = "The human attempt to control supernatural/God events for a desired outcome is called ______."
        astrAboriginal(6, 2) = "magic"
        astrAboriginal(6, 3) = "ShortAns"
        astrAboriginal(6, 4) = "1000"

        'Sikhism Questions
        astrSikkhism(0, 0) = "Which country did this religion began?"
        astrSikkhism(0, 1) = "India|Iran|Mecca|Pakistan"
        astrSikkhism(0, 2) = "A"
        astrSikkhism(0, 3) = "MC"
        astrSikkhism(0, 4) = "100"

        astrSikkhism(1, 0) = "Sikhs believe in multiple gods"
        astrSikkhism(1, 2) = "B"
        astrSikkhism(1, 3) = "TrueFalse"
        astrSikkhism(1, 4) = "200"

        astrSikkhism(2, 0) = "The group of Sikhs who have taken special vows to wear the 5 K's are called _______."
        astrSikkhism(2, 1) = "Kesh|Kirpan|Kaccha|Khalsa"
        astrSikkhism(2, 2) = "D"
        astrSikkhism(2, 3) = "MC"
        astrSikkhism(2, 4) = "300"

        astrSikkhism(3, 0) = "A ______ is a spiritual guide who helps one along the path of meditation and knowledge."
        astrSikkhism(3, 2) = "Guru"
        astrSikkhism(3, 3) = "ShortAns"
        astrSikkhism(3, 4) = "400"

        astrSikkhism(4, 0) = "Which item symbolizes cleanliness with a comb?"
        astrSikkhism(4, 1) = "Kara|Kanga|Kaccha|Kirpan"
        astrSikkhism(4, 2) = "B"
        astrSikkhism(4, 3) = "MC"
        astrSikkhism(4, 4) = "500"

        astrSikkhism(5, 0) = "The word Sikh means student or teacher."
        astrSikkhism(5, 2) = "A"
        astrSikkhism(5, 3) = "TrueFalse"
        astrSikkhism(5, 4) = "800"

        astrSikkhism(6, 0) = "Which item is baggy pants which signifies faith to a spouse?"
        astrSikkhism(6, 1) = "Kara|Kesh|Kaccha|Kirpan"
        astrSikkhism(6, 2) = "C"
        astrSikkhism(6, 3) = "MC"
        astrSikkhism(6, 4) = "1000"

        'Hinduism Questions
        astrHinduism(0, 0) = "Where are Hindus place of worship?"
        astrHinduism(0, 1) = "Mosque|Church|Gurdwara|Temple"
        astrHinduism(0, 2) = "D"
        astrHinduism(0, 3) = "MC"
        astrHinduism(0, 4) = "100"

        astrHinduism(1, 0) = "Which country did Hinduism began?"
        astrHinduism(1, 2) = "india"
        astrHinduism(1, 3) = "ShortAns"
        astrHinduism(1, 4) = "200"

        astrHinduism(2, 0) = "Which example is not part of Ahisma?"
        astrHinduism(2, 1) = "non-violence|no opportunities for outcastes|fasts, marches, and peaceful protests|India’s Independence in 1947"
        astrHinduism(2, 2) = "B"
        astrHinduism(2, 3) = "MC"
        astrHinduism(2, 4) = "300"

        astrHinduism(3, 0) = "Hindus can move up levels on the caste system through marriage."
        astrHinduism(3, 2) = "B"
        astrHinduism(3, 3) = "TrueFalse"
        astrHinduism(3, 4) = "400"

        astrHinduism(4, 0) = "For Hindus the force which is the foundation of all life is known as __________."
        astrHinduism(4, 1) = "Atman|Brahmin|Brahman|Brahma"
        astrHinduism(4, 2) = "C"
        astrHinduism(4, 3) = "MC"
        astrHinduism(4, 4) = "500"

        astrHinduism(5, 0) = "What does Karma mean in Hinduism?"
        astrHinduism(5, 1) = "What goes around comes around|Good actions give us a better reincarnation|Sum of All Actions|All of the Above"
        astrHinduism(5, 2) = "D"
        astrHinduism(5, 3) = "MC"
        astrHinduism(5, 4) = "800"

        astrHinduism(6, 0) = "The endless cycle of rebirth and death is called _______."
        astrHinduism(6, 1) = "Samsara|Moksha|Samskara|Dharma"
        astrHinduism(6, 2) = "A"
        astrHinduism(6, 3) = "MC"
        astrHinduism(6, 4) = "1000"

        'The Buddhism Questions
        astrBuddhism(0, 0) = "Who was the founder of Buddhism"
        astrBuddhism(0, 1) = "Guru Nanak|Siddharta Gautama|Abraham|Dalai Lama"
        astrBuddhism(0, 2) = "B"
        astrBuddhism(0, 3) = "MC"
        astrBuddhism(0, 4) = "100"

        astrBuddhism(1, 0) = "Where did this religion began"
        astrBuddhism(1, 1) = "India|China|Tibet|Korea"
        astrBuddhism(1, 2) = "A"
        astrBuddhism(1, 3) = "MC"
        astrBuddhism(1, 4) = "200"

        astrBuddhism(2, 0) = "Which example of suffering did Siddharta not see?"
        astrBuddhism(2, 1) = "Poverty|Death|Violence|Sick"
        astrBuddhism(2, 2) = "C"
        astrBuddhism(2, 3) = "MC"
        astrBuddhism(2, 4) = "300"

        astrBuddhism(3, 0) = "When Siddharta was born, lotus flowers were growing under every step he took."
        astrBuddhism(3, 2) = "A"
        astrBuddhism(3, 3) = "TrueFalse"
        astrBuddhism(3, 4) = "400"

        astrBuddhism(4, 0) = "What do you need to follow to achieve Nirvana?"
        astrBuddhism(4, 1) = "Three Universal Truths|Four Noble Truths|Eightfold Path|All of the Above"
        astrBuddhism(4, 2) = "D"
        astrBuddhism(4, 3) = "MC"
        astrBuddhism(4, 4) = "500"

        astrBuddhism(5, 0) = "What is the Buddhist equivalent of the devil?"
        astrBuddhism(5, 1) = "Satori|Dukkha|Mara|Tanha"
        astrBuddhism(5, 2) = "C"
        astrBuddhism(5, 3) = "MC"
        astrBuddhism(5, 4) = "800"

        astrBuddhism(6, 0) = "What does Annica mean?"
        astrBuddhism(6, 1) = "No soul|Suffering|After life|Impermanance"
        astrBuddhism(6, 2) = "D"
        astrBuddhism(6, 3) = "MC"
        astrBuddhism(6, 4) = "1000"

        'The Judaism Questions
        astrJudaism(0, 0) = "Who was the person who led the Israelites out of Egypt?"
        astrJudaism(0, 1) = "Abraham|Jesus|Moses|God"
        astrJudaism(0, 2) = "C"
        astrJudaism(0, 3) = "MC"
        astrJudaism(0, 4) = "100"

        astrJudaism(1, 0) = "The Holy Book of Judaism is called the _______."
        astrJudaism(1, 1) = "Vedas|Bible|Koran|Torah"
        astrJudaism(1, 2) = "D"
        astrJudaism(1, 3) = "MC"
        astrJudaism(1, 4) = "200"

        astrJudaism(2, 0) = "What is the name of God for Judaism?"
        astrJudaism(2, 1) = "Adonai|G-d|El|All of the Above"
        astrJudaism(2, 2) = "D"
        astrJudaism(2, 3) = "MC"
        astrJudaism(2, 4) = "300"

        astrJudaism(3, 0) = "The Danish people managed to save about 95% of their Jewish population."
        astrJudaism(3, 2) = "A"
        astrJudaism(3, 3) = "TrueFalse"
        astrJudaism(3, 4) = "400"

        astrJudaism(4, 0) = "Which city/country is considered the Promised Land?"
        astrJudaism(4, 1) = "Israel|Canaan|Jerusalem|Iran"
        astrJudaism(4, 2) = "B"
        astrJudaism(4, 3) = "MC"
        astrJudaism(4, 4) = "500"

        astrJudaism(5, 0) = "The word Holocaust is a Greek word meaning ________."
        astrJudaism(5, 1) = "Massacre of one race|Whole burning|Hell|Death"
        astrJudaism(5, 2) = "B"
        astrJudaism(5, 3) = "MC"
        astrJudaism(5, 4) = "800"

        astrJudaism(6, 0) = "Which Jewish is the holiest day of the Jewish year?"
        astrJudaism(6, 1) = "Hanukkah|Rosh Hashanah|Yom Kippur|Shabbat"
        astrJudaism(6, 2) = "C"
        astrJudaism(6, 3) = "MC"
        astrJudaism(6, 4) = "1000"

        'The Islam Questions
        astrIslam(0, 0) = "The Holy Book of Islam is called the _______."
        astrIslam(0, 1) = "Torah|Bible|Koran|Vedas"
        astrIslam(0, 2) = "C"
        astrIslam(0, 3) = "MC"
        astrIslam(0, 4) = "100"

        astrIslam(1, 0) = "Mohammad is seen by Muslims as the Son of God?"
        astrIslam(1, 2) = "B"
        astrIslam(1, 3) = "TrueFalse"
        astrIslam(1, 4) = "200"

        astrIslam(2, 0) = "What are tessellations?"
        astrIslam(2, 1) = "Symbolic dancing|Decorative writing|Individual tiles with drawings| Different types of Music"
        astrIslam(2, 2) = "C"
        astrIslam(2, 3) = "MC"
        astrIslam(2, 4) = "300"

        astrIslam(3, 0) = "Mohammad and his followers captured the city of _______."
        astrIslam(3, 1) = "Mecca|Jerusalem|Iran|Medina"
        astrIslam(3, 2) = "A"
        astrIslam(3, 3) = "MC"
        astrIslam(3, 4) = "400"

        astrIslam(4, 0) = "The term jihad means"
        astrIslam(4, 1) = "Submission to God’s Will|First call|Holy war|Messenger of God"
        astrIslam(4, 2) = "C"
        astrIslam(4, 3) = "MC"
        astrIslam(4, 4) = "500"

        astrIslam(5, 0) = "Which of these examples represent almsgiving?"
        astrIslam(5, 1) = "Ramadan|Say the creed|Visit the Kabba in Mecca|Give money to poor"
        astrIslam(5, 2) = "D"
        astrIslam(5, 3) = "MC"
        astrIslam(5, 4) = "800"

        astrIslam(6, 0) = "How many names for God do Muslims have?"
        astrIslam(6, 2) = "99"
        astrIslam(6, 3) = "ShortAns"
        astrIslam(6, 4) = "1000"

        'The Christianity Questions

        astrChristian(0, 0) = "Who were Jesus' parents"
        astrChristian(0, 1) = "Mom and dad|God and his wife|Mary and Joseph|None of the Above"
        astrChristian(0, 2) = "C"
        astrChristian(0, 3) = "MC"
        astrChristian(0, 4) = "100"

        astrChristian(1, 0) = "Who was the founder of Chiristianity?"
        astrChristian(1, 1) = "God|Jesus|Moses|Abraham"
        astrChristian(1, 2) = "B"
        astrChristian(1, 3) = "MC"
        astrChristian(1, 4) = "200"

        astrChristian(2, 0) = "Where did Christianity began?"
        astrChristian(2, 1) = "India|Jeruselem|Rome|Mecca"
        astrChristian(2, 2) = "B"
        astrChristian(2, 3) = "MC"
        astrChristian(2, 4) = "300"

        astrChristian(3, 0) = "What is the holy book for Christianity?"
        astrChristian(3, 1) = "Torah|Bible|Qu’ran|Vedas"
        astrChristian(3, 2) = "B"
        astrChristian(3, 3) = "MC"
        astrChristian(3, 4) = "400"

        astrChristian(4, 0) = "Easter is a very important holiday for Christians."
        astrChristian(4, 2) = "A"
        astrChristian(4, 3) = "TrueFalse"
        astrChristian(4, 4) = "500"

        astrChristian(5, 0) = "What do Christians do to pray to God?"
        astrChristian(5, 1) = "Kneel down|Sign of the Cross|Wave their hand to God|both a) and b) only"
        astrChristian(5, 2) = "D"
        astrChristian(5, 3) = "MC"
        astrChristian(5, 4) = "800"

        astrChristian(6, 0) = "The Sacrament of Matrimony is _______."
        astrChristian(6, 1) = "a vow made by a couple|eating bread and wine|ask forgiveness from God|become a priest"
        astrChristian(6, 2) = "A"
        astrChristian(6, 3) = "MC"
        astrChristian(6, 4) = "1000"


        '-------------JEOPARDY ROUND 2 QUESTIONS

        'The Aboriginal Questions
        astrAboriginal(7, 0) = "Tabooed objects are thought to be magical and holy."
        astrAboriginal(7, 2) = "B"
        astrAboriginal(7, 3) = "TrueFalse"
        astrAboriginal(7, 4) = "200"

        astrAboriginal(8, 0) = "Which are not characteristics of Aboriginals?"
        astrAboriginal(8, 1) = "Secret areas and Symbolism|Community and Ownership|Totem and Animism|Nature and Taboo"
        astrAboriginal(8, 2) = "A"
        astrAboriginal(8, 3) = "MC"
        astrAboriginal(8, 4) = "400"

        astrAboriginal(9, 0) = "In a community, everyone is equal"
        astrAboriginal(9, 2) = "A"
        astrAboriginal(9, 3) = "TrueFalse"
        astrAboriginal(9, 4) = "600"

        astrAboriginal(10, 0) = "Another name for the medicine man/woman that uses magic is called a _______."
        astrAboriginal(10, 1) = "Healer|Witch Doctor|Shaman|Sorcerer"
        astrAboriginal(10, 2) = "C"
        astrAboriginal(10, 3) = "MC"
        astrAboriginal(10, 4) = "800"

        astrAboriginal(11, 0) = "Wearing animal skins allowed you to take on he power of the animal."
        astrAboriginal(11, 2) = "A"
        astrAboriginal(11, 3) = "TrueFalse"
        astrAboriginal(11, 4) = "1000"

        astrAboriginal(12, 0) = "What does the word Primal mean?"
        astrAboriginal(12, 1) = "Before or After|Ape or Monkey|Important or Essential|First or Beginning"
        astrAboriginal(12, 2) = "D"
        astrAboriginal(12, 3) = "MC"
        astrAboriginal(12, 4) = "1600"

        astrAboriginal(13, 0) = "Bones painted blood red symbolizes ________."
        astrAboriginal(13, 1) = "Birth|life|After-Life|Death"
        astrAboriginal(13, 2) = "B"
        astrAboriginal(13, 3) = "MC"
        astrAboriginal(13, 4) = "2000"

        'The Sikhism Questions
        astrSikkhism(7, 0) = "Who was the founder of Sikhism?"
        astrSikkhism(7, 1) = "Mohammad|Abraham|Guru Nanak|Gautama"
        astrSikkhism(7, 2) = "C"
        astrSikkhism(7, 3) = "MC"
        astrSikkhism(7, 4) = "200"

        astrSikkhism(8, 0) = "What is Sikhs place of worship?"
        astrSikkhism(8, 1) = "Mosque|Church|Gurdwara|Temple"
        astrSikkhism(8, 2) = "C"
        astrSikkhism(8, 3) = "MC"
        astrSikkhism(8, 4) = "400"

        astrSikkhism(9, 0) = "Sikhs wear the turban as a sign of faith."
        astrSikkhism(9, 2) = "B"
        astrSikkhism(9, 3) = "TrueFalse"
        astrSikkhism(9, 4) = "600"

        astrSikkhism(10, 0) = "What is the name of the Sikhism holy book"
        astrSikkhism(10, 1) = "Torah|Vedas|Qu'ran|Guru Granth"
        astrSikkhism(10, 2) = "D"
        astrSikkhism(10, 3) = "MC"
        astrSikkhism(10, 4) = "800"

        astrSikkhism(11, 0) = "Which item is a ceremonial dagger which is a sign of respect?"
        astrSikkhism(11, 1) = "Kara|Kirpan|Kanga|Kesh"
        astrSikkhism(11, 2) = "B"
        astrSikkhism(11, 3) = "MC"
        astrSikkhism(11, 4) = "1000"

        astrSikkhism(12, 0) = "What is the Guru Granth Sahib's language?"
        astrSikkhism(12, 2) = "Punjabi"
        astrSikkhism(12, 3) = "ShortAns"
        astrSikkhism(12, 4) = "1600"

        astrSikkhism(13, 0) = "Which item is a steel bracelet which is a sign of respect?"
        astrSikkhism(13, 1) = "Kara|Kirpan|Kanga|Kesh"
        astrSikkhism(13, 2) = "A"
        astrSikkhism(13, 3) = "MC"
        astrSikkhism(13, 4) = "2000"

        'The Hinduism Questions
        astrHinduism(7, 0) = "Who was the person who wanted independence for India?"
        astrHinduism(7, 1) = "Guru Granth|Mohommad|Mahatma Ghandi|Lord Brahman"
        astrHinduism(7, 2) = "C"
        astrHinduism(7, 3) = "MC"
        astrHinduism(7, 4) = "200"

        astrHinduism(8, 0) = "Hinduism is a polytheistic religion"
        astrHinduism(8, 2) = "B"
        astrHinduism(8, 3) = "TrueFalse"
        astrHinduism(8, 4) = "400"

        astrHinduism(9, 0) = "What language of Holy Scriptures is Hinduism?"
        astrHinduism(9, 1) = "Arabic|Sanskrit|Pali|Hindi"
        astrHinduism(9, 2) = "B"
        astrHinduism(9, 3) = "MC"
        astrHinduism(9, 4) = "600"

        astrHinduism(10, 0) = "How many main social divisions are in the caste?"
        astrHinduism(10, 2) = "4"
        astrHinduism(10, 3) = "ShortAns"
        astrHinduism(10, 4) = "800"

        astrHinduism(11, 0) = "What does Mahatma mean"
        astrHinduism(11, 1) = "Great deed|Great wonders|Great person|Great soul"
        astrHinduism(11, 2) = "D"
        astrHinduism(11, 3) = "MC"
        astrHinduism(11, 4) = "1000"

        astrHinduism(12, 0) = "Maya is what prevents Hindus from reaching Brahman."
        astrHinduism(12, 2) = "A"
        astrHinduism(12, 3) = "TrueFalse"
        astrHinduism(12, 4) = "1600"

        astrHinduism(13, 0) = "The cycle of reincarnation is stopped, and atman is united with Brahman"
        astrHinduism(13, 1) = "Samsara|Moksha|Samskara|Dharma"
        astrHinduism(13, 2) = "B"
        astrHinduism(13, 3) = "MC"
        astrHinduism(13, 4) = "2000"

        'The Buddhism Questions
        astrBuddhism(7, 0) = "The three baskets and the collection of early Buddhist Scriptures is called ________?"
        astrBuddhism(7, 1) = "Trimurti|Trigonometry|Thervada|Tripitaka"
        astrBuddhism(7, 2) = "D"
        astrBuddhism(7, 3) = "MC"
        astrBuddhism(7, 4) = "200"

        astrBuddhism(8, 0) = "Which religion did Siddharta originally believed?"
        astrBuddhism(8, 1) = "Islam|Christianity|Sikhism|Hinduism"
        astrBuddhism(8, 2) = "D"
        astrBuddhism(8, 3) = "MC"
        astrBuddhism(8, 4) = "400"

        astrBuddhism(9, 0) = "Buddha died by eating poisonous mushrooms."
        astrBuddhism(9, 2) = "A"
        astrBuddhism(9, 3) = "TrueFalse"
        astrBuddhism(9, 4) = "600"

        astrBuddhism(10, 0) = "The everlasting state of joy and peace is called ______."
        astrBuddhism(10, 1) = "Mahayanna|Meditation|Nirvana|Brahmin"
        astrBuddhism(10, 2) = "C"
        astrBuddhism(10, 3) = "MC"
        astrBuddhism(10, 4) = "800"

        astrBuddhism(11, 0) = "Siddharta answered what question."
        astrBuddhism(11, 1) = "Why do people fight?|Why was he unhappy?|Why are people happy?|Why do people suffer?"
        astrBuddhism(11, 2) = "D"
        astrBuddhism(11, 3) = "MC"
        astrBuddhism(11, 4) = "1000"

        astrBuddhism(12, 0) = "A chant that monks do is called ________."
        astrBuddhism(12, 1) = "Mundras|Mantras|Mandalas|Mantini"
        astrBuddhism(12, 2) = "B"
        astrBuddhism(12, 3) = "MC"
        astrBuddhism(12, 4) = "1600"

        astrBuddhism(13, 0) = "What does Annata mean?"
        astrBuddhism(13, 1) = "No soul|Suffering|After life|Impermanance"
        astrBuddhism(13, 2) = "A"
        astrBuddhism(13, 3) = "MC"
        astrBuddhism(13, 4) = "2000"

        'The Judaism Questions
        astrJudaism(7, 0) = "Which country did Judaism began?"
        astrJudaism(7, 2) = "jerusalem"
        astrJudaism(7, 3) = "ShortAns"
        astrJudaism(7, 4) = "200"

        astrJudaism(8, 0) = "Which person is considered to be the founder of Judaism?"
        astrJudaism(8, 1) = "Moses|Jacob|Abraham|Issac"
        astrJudaism(8, 2) = "C"
        astrJudaism(8, 3) = "MC"
        astrJudaism(8, 4) = "400"

        astrJudaism(9, 0) = "Where are Jews place of worship?"
        astrJudaism(9, 1) = "Mosque|Synagogue|Gurdwara|Temple"
        astrJudaism(9, 2) = "B"
        astrJudaism(9, 3) = "MC"
        astrJudaism(9, 4) = "600"

        astrJudaism(10, 0) = "Where are Jews place of worship?"
        astrJudaism(10, 1) = "Yellow Star of David|Passports stamped with a J|Non- Kosher food was forbidden|Jews could not vote"
        astrJudaism(10, 2) = "C"
        astrJudaism(10, 3) = "MC"
        astrJudaism(10, 4) = "800"

        astrJudaism(11, 0) = "Which branch of Judaism keeps kosher?"
        astrJudaism(11, 1) = "Orthodox|Reform|Conservative|All of the Above"
        astrJudaism(11, 2) = "A"
        astrJudaism(11, 3) = "MC"
        astrJudaism(11, 4) = "1000"

        astrJudaism(12, 0) = "Which Jewish holiday represents the sart of a new Jewish year"
        astrJudaism(12, 1) = "Hanukkah|Yom Kippur|Rosh Hashanah|Shabbat"
        astrJudaism(12, 2) = "C"
        astrJudaism(12, 3) = "MC"
        astrJudaism(12, 4) = "1600"

        astrJudaism(13, 0) = "What was the superior political group that Hitler commanded"
        astrJudaism(13, 2) = "Nazis"
        astrJudaism(13, 3) = "ShortAns"
        astrJudaism(13, 4) = "2000"

        'The Islam Questions
        astrIslam(7, 0) = "Muslims are called to pray"
        astrIslam(7, 1) = "5 times a day|5 times a week|3 times a day|3 times a week"
        astrIslam(7, 2) = "C"
        astrIslam(7, 3) = "MC"
        astrIslam(7, 4) = "200"

        astrIslam(8, 0) = "What is the Shahadah?"
        astrIslam(8, 1) = "2 lined statement|A creed for Muslims|Describes Monotheism|All of the Above"
        astrIslam(8, 2) = "D"
        astrIslam(8, 3) = "MC"
        astrIslam(8, 4) = "400"

        astrIslam(9, 0) = "A Muslim must do this once in his or her lifetime?"
        astrIslam(9, 1) = "Memorize the Koran|Make a pilgrimage to Mecca|Visit a Mosque|Visit the 5 pillars of Islam"
        astrIslam(9, 2) = "B"
        astrIslam(9, 3) = "MC"
        astrIslam(9, 4) = "600"

        astrIslam(10, 0) = "The word Islam means"
        astrIslam(10, 1) = "Belief in Allah|Mohammad is God’s prophet|Gabriel speaks|Submission to God’s will"
        astrIslam(10, 2) = "D"
        astrIslam(10, 3) = "MC"
        astrIslam(10, 4) = "800"

        astrIslam(11, 0) = "When Muslim people pray they have to face in the direction of ______?"
        astrIslam(11, 1) = "Medina|Kaaba|Mecca|Iran"
        astrIslam(11, 2) = "C"
        astrIslam(11, 3) = "MC"
        astrIslam(11, 4) = "1000"

        astrIslam(12, 0) = "A Muslims most sacred duty is ________."
        astrIslam(12, 1) = "The Hajj|Pray 5 times a day|Memorize the Koran|Give money to poor"
        astrIslam(12, 2) = "A"
        astrIslam(12, 3) = "MC"
        astrIslam(12, 4) = "1600"

        astrIslam(13, 0) = "The Sunnis and Shi'ites are different from each other in terms of how they look at _______."
        astrIslam(13, 1) = "Prayer|God|The leader of Islam|Violence"
        astrIslam(13, 2) = "C"
        astrIslam(13, 3) = "MC"
        astrIslam(13, 4) = "2000"

        'The Christianity Questions

        astrChristian(7, 0) = "As Christians, we believe in 2 creeds, the Apostle’s creed and Nicene creed."
        astrChristian(7, 2) = "A"
        astrChristian(7, 3) = "TrueFalse"
        astrChristian(7, 4) = "200"

        astrChristian(8, 0) = "The final book in the bible is called _______."
        astrChristian(8, 1) = "Revelations|Acts|Gospels|Letters"
        astrChristian(8, 2) = "A"
        astrChristian(8, 3) = "MC"
        astrChristian(8, 4) = "400"

        astrChristian(9, 0) = "Which is not a gospel in the Bible?"
        astrChristian(9, 1) = "Matthew|Paul|Luke|John"
        astrChristian(9, 2) = "B"
        astrChristian(9, 3) = "MC"
        astrChristian(9, 4) = "600"

        astrChristian(10, 0) = "The Sacrament of Communion is _____."
        astrChristian(10, 1) = "eating bread and wine|becoming a Christian adolescent|becoming a priest|curing the sick"
        astrChristian(10, 2) = "A"
        astrChristian(10, 3) = "MC"
        astrChristian(10, 4) = "800"

        astrChristian(11, 0) = "The Great Schism was the split between Western Orthodox and Eastern Roman Catholic."
        astrChristian(11, 2) = "B"
        astrChristian(11, 3) = "TrueFalse"
        astrChristian(11, 4) = "1000"

        astrChristian(12, 0) = "The holiest position in Christianity is _____."
        astrChristian(12, 2) = "Pope"
        astrChristian(12, 3) = "ShortAns"
        astrChristian(12, 4) = "1600"

        astrChristian(13, 0) = "The Sacrament of Ordination is _____."
        astrChristian(13, 1) = "eating bread and wine|becoming a Christian adolescent|becoming a priest|curing the sick"
        astrChristian(13, 2) = "C"
        astrChristian(13, 3) = "MC"
        astrChristian(13, 4) = "2000"






        'Starts up intro and startup form
        StartupWindow_Form.ShowDialog()

        Call Updates()
        If intNumOfTeams >= 1 Then Team1_GroupBox.Visible = True
        If intNumOfTeams >= 2 Then Team2_GroupBox.Visible = True
        If intNumOfTeams >= 3 Then Team3_GroupBox.Visible = True
        If intNumOfTeams >= 4 Then Team4_GroupBox.Visible = True
        If intNumOfTeams >= 5 Then Team5_GroupBox.Visible = True
        Intro_Timer.Enabled = True
    End Sub

    Private Sub DoIntro()
        'Does a fun little intro in the beginning with sound
        My.Computer.Audio.Play(My.Resources.Jeopardy_boardfill, AudioPlayMode.Background)
        Dim i As New Integer
        For j = 0 To 10

            For Each JeoButton In lbtnJeoButtons
                i = Int(Rnd() * 6) + 1
                If i = 1 Then JeoButton.BackColor = Color.Blue
                If i = 2 Then JeoButton.BackColor = Color.Red
                If i = 3 Then JeoButton.BackColor = Color.Green
                If i = 4 Then JeoButton.BackColor = Color.Yellow
                If i = 5 Then JeoButton.BackColor = Color.Orange
                If i = 6 Then JeoButton.BackColor = Color.Purple
            Next
            i = Int(Rnd() * intNumOfTeams) + 1
            intCurTeam = i
            Turn_Label.Text = "It is currently Team " & intCurTeam & "'s turn!"

            Me.Refresh()
            Threading.Thread.Sleep(200)
        Next


        For Each JeoButton In lbtnJeoButtons
            JeoButton.Enabled = True
            JeoButton.Visible = True
            JeoButton.BackColor = Color.Blue
            If blnDoubleJeo = True Then
                If InStr(JeoButton.Name, "1") Then JeoButton.Text = "200"
                If InStr(JeoButton.Name, "2") Then JeoButton.Text = "400"
                If InStr(JeoButton.Name, "3") Then JeoButton.Text = "600"
                If InStr(JeoButton.Name, "4") Then JeoButton.Text = "800"
                If InStr(JeoButton.Name, "5") Then JeoButton.Text = "1000"
                If InStr(JeoButton.Name, "6") Then JeoButton.Text = "1600"
                If InStr(JeoButton.Name, "7") Then JeoButton.Text = "2000"
            End If
        Next
        If blnDoubleJeo = True Then
            intDailyDouble = 0
            RoundTwo_Label.Visible = True
        End If
        Intro_Timer.Enabled = False
    End Sub

    Private Sub Intro_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Intro_Timer.Tick
        Call DoIntro()
        Intro_Timer.Enabled = False
    End Sub

    Private Sub AllJeoButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aboriginal1_Button.Click, Aboriginal2_Button.Click, Aboriginal3_Button.Click, Aboriginal4_Button.Click, Aboriginal5_Button.Click, Aboriginal6_Button.Click, Aboriginal7_Button.Click, _
        Sikkhism1_Button.Click, Sikkhism2_Button.Click, Sikkhism3_Button.Click, Sikkhism4_Button.Click, Sikkhism5_Button.Click, Sikkhism6_Button.Click, Sikkhism7_Button.Click, _
        Hinduism1_Button.Click, Hinduism2_Button.Click, Hinduism3_Button.Click, Hinduism4_Button.Click, Hinduism5_Button.Click, Hinduism6_Button.Click, Hinduism7_Button.Click, _
        Buddhism1_Button.Click, Buddhism2_Button.Click, Buddhism3_Button.Click, Buddhism4_Button.Click, Buddhism5_Button.Click, Buddhism6_Button.Click, Buddhism7_Button.Click, _
        Judaism1_Button.Click, Judaism2_Button.Click, Judaism3_Button.Click, Judaism4_Button.Click, Judaism5_Button.Click, Judaism6_Button.Click, Judaism7_Button.Click, _
        Christian1_Button.Click, Christian2_Button.Click, Christian3_Button.Click, Christian4_Button.Click, Christian5_Button.Click, Christian6_Button.Click, Christian7_Button.Click, _
        Islam1_Button.Click, Islam2_Button.Click, Islam3_Button.Click, Islam4_Button.Click, Islam5_Button.Click, Islam6_Button.Click, Islam7_Button.Click
        'The main part of the code

        Dim strJeoButton As String = sender.name
        If InStr(strJeoButton, "Aboriginal") Then LoadQuestion("Aboriginal", strJeoButton.Substring(10, 1))
        If InStr(strJeoButton, "Sikkhism") Then LoadQuestion("Sikkhism", strJeoButton.Substring(8, 1))
        If InStr(strJeoButton, "Hinduism") Then LoadQuestion("Hinduism", strJeoButton.Substring(8, 1))
        If InStr(strJeoButton, "Buddhism") Then LoadQuestion("Buddhism", strJeoButton.Substring(8, 1))
        If InStr(strJeoButton, "Judaism") Then LoadQuestion("Judaism", strJeoButton.Substring(7, 1))
        If InStr(strJeoButton, "Christian") Then LoadQuestion("Christian", strJeoButton.Substring(9, 1))
        If InStr(strJeoButton, "Islam") Then LoadQuestion("Islam", strJeoButton.Substring(5, 1))

        If Not sender.backcolor = Color.Red Then
            'Display Results and Highlight Question Red

            'Daily Double
            If intDailyDouble < 3 Then
                Dim i As Integer
                i = Int(Rnd() * 6) + 1
                If i = 3 Then
                    My.Computer.Audio.Play(My.Resources.Jeopardy_daily2x, AudioPlayMode.Background)
                    intDailyDouble += 1
                    If MsgBox("You've got a daily double question. Would you like the amount of points for this question to be doubled?" & Environment.NewLine & " (Remember: If you do not get the answer right, you will lose more points!)", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Religion Jeopardy") = MsgBoxResult.Yes Then
                        intPoints *= 2 'Doubles Points
                    End If
                End If
            End If

            QuestionWindow_Form.ShowDialog()

            sender.backcolor = Color.Red
            Call Updates() 'Updates all points, the leader, and the team's turn
            Call UpdateLeader()
        Else
            AnswerWindow_Form.ShowDialog()
        End If
    End Sub

    Private Sub LoadQuestion(ByVal ReligionName As String, ByVal QuestionNum As Integer)
        If blnDoubleJeo = False Then
            If ReligionName = "Aboriginal" Then
                strQuestion = astrAboriginal(QuestionNum - 1, 0)
                strPossAnswer = astrAboriginal(QuestionNum - 1, 1)
                strAnswer = astrAboriginal(QuestionNum - 1, 2)
                strTypeAnswer = astrAboriginal(QuestionNum - 1, 3)
                intPoints = astrAboriginal(QuestionNum - 1, 4)
            ElseIf ReligionName = "Sikkhism" Then
                strQuestion = astrSikkhism(QuestionNum - 1, 0)
                strPossAnswer = astrSikkhism(QuestionNum - 1, 1)
                strAnswer = astrSikkhism(QuestionNum - 1, 2)
                strTypeAnswer = astrSikkhism(QuestionNum - 1, 3)
                intPoints = astrSikkhism(QuestionNum - 1, 4)
            ElseIf ReligionName = "Hinduism" Then
                strQuestion = astrHinduism(QuestionNum - 1, 0)
                strPossAnswer = astrHinduism(QuestionNum - 1, 1)
                strAnswer = astrHinduism(QuestionNum - 1, 2)
                strTypeAnswer = astrHinduism(QuestionNum - 1, 3)
                intPoints = astrHinduism(QuestionNum - 1, 4)
            ElseIf ReligionName = "Buddhism" Then
                strQuestion = astrBuddhism(QuestionNum - 1, 0)
                strPossAnswer = astrBuddhism(QuestionNum - 1, 1)
                strAnswer = astrBuddhism(QuestionNum - 1, 2)
                strTypeAnswer = astrBuddhism(QuestionNum - 1, 3)
                intPoints = astrBuddhism(QuestionNum - 1, 4)
            ElseIf ReligionName = "Judaism" Then
                strQuestion = astrJudaism(QuestionNum - 1, 0)
                strPossAnswer = astrJudaism(QuestionNum - 1, 1)
                strAnswer = astrJudaism(QuestionNum - 1, 2)
                strTypeAnswer = astrJudaism(QuestionNum - 1, 3)
                intPoints = astrJudaism(QuestionNum - 1, 4)
            ElseIf ReligionName = "Christian" Then
                strQuestion = astrChristian(QuestionNum - 1, 0)
                strPossAnswer = astrChristian(QuestionNum - 1, 1)
                strAnswer = astrChristian(QuestionNum - 1, 2)
                strTypeAnswer = astrChristian(QuestionNum - 1, 3)
                intPoints = astrChristian(QuestionNum - 1, 4)
            ElseIf ReligionName = "Islam" Then
                strQuestion = astrIslam(QuestionNum - 1, 0)
                strPossAnswer = astrIslam(QuestionNum - 1, 1)
                strAnswer = astrIslam(QuestionNum - 1, 2)
                strTypeAnswer = astrIslam(QuestionNum - 1, 3)
                intPoints = astrIslam(QuestionNum - 1, 4)
            End If
        Else
            If ReligionName = "Aboriginal" Then
                strQuestion = astrAboriginal(QuestionNum + 6, 0)
                strPossAnswer = astrAboriginal(QuestionNum + 6, 1)
                strAnswer = astrAboriginal(QuestionNum + 6, 2)
                strTypeAnswer = astrAboriginal(QuestionNum + 6, 3)
                intPoints = astrAboriginal(QuestionNum + 6, 4)
            ElseIf ReligionName = "Sikkhism" Then
                strQuestion = astrSikkhism(QuestionNum + 6, 0)
                strPossAnswer = astrSikkhism(QuestionNum + 6, 1)
                strAnswer = astrSikkhism(QuestionNum + 6, 2)
                strTypeAnswer = astrSikkhism(QuestionNum + 6, 3)
                intPoints = astrSikkhism(QuestionNum + 6, 4)
            ElseIf ReligionName = "Hinduism" Then
                strQuestion = astrHinduism(QuestionNum + 6, 0)
                strPossAnswer = astrHinduism(QuestionNum + 6, 1)
                strAnswer = astrHinduism(QuestionNum + 6, 2)
                strTypeAnswer = astrHinduism(QuestionNum + 6, 3)
                intPoints = astrHinduism(QuestionNum + 6, 4)
            ElseIf ReligionName = "Buddhism" Then
                strQuestion = astrBuddhism(QuestionNum + 6, 0)
                strPossAnswer = astrBuddhism(QuestionNum + 6, 1)
                strAnswer = astrBuddhism(QuestionNum + 6, 2)
                strTypeAnswer = astrBuddhism(QuestionNum + 6, 3)
                intPoints = astrBuddhism(QuestionNum + 6, 4)
            ElseIf ReligionName = "Judaism" Then
                strQuestion = astrJudaism(QuestionNum + 6, 0)
                strPossAnswer = astrJudaism(QuestionNum + 6, 1)
                strAnswer = astrJudaism(QuestionNum + 6, 2)
                strTypeAnswer = astrJudaism(QuestionNum + 6, 3)
                intPoints = astrJudaism(QuestionNum + 6, 4)
            ElseIf ReligionName = "Christian" Then
                strQuestion = astrChristian(QuestionNum + 6, 0)
                strPossAnswer = astrChristian(QuestionNum + 6, 1)
                strAnswer = astrChristian(QuestionNum + 6, 2)
                strTypeAnswer = astrChristian(QuestionNum + 6, 3)
                intPoints = astrChristian(QuestionNum + 6, 4)
            ElseIf ReligionName = "Islam" Then
                strQuestion = astrIslam(QuestionNum + 6, 0)
                strPossAnswer = astrIslam(QuestionNum + 6, 1)
                strAnswer = astrIslam(QuestionNum + 6, 2)
                strTypeAnswer = astrIslam(QuestionNum + 6, 3)
                intPoints = astrIslam(QuestionNum + 6, 4)
            End If
        End If
        strReligion = ReligionName
    End Sub

    Private Sub Updates()
        'Updates Points
        Team1Points_Label.Text = aintTeamScores(0)
        Team2Points_Label.Text = aintTeamScores(1)
        Team3Points_Label.Text = aintTeamScores(2)
        Team4Points_Label.Text = aintTeamScores(3)
        Team5Points_Label.Text = aintTeamScores(4)

        'Updates Turn label
        Turn_Label.Text = "It is currently Team " & intCurTeam & "'s turn!"

        'Updates the Jeopardy Usage
        intJeopardyGameUsage += 1
        If intJeopardyGameUsage >= 50 And blnDoubleJeo = False Then
            My.Computer.Audio.Play(My.Resources.Jeopardy_round_end, AudioPlayMode.Background)
            MsgBox("Since you have answered the last question for Round 1, here comes a bonus question.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Religion Jeopardy")
            strReligion = "Christian (Bonus)"
            strQuestion = "What is Sunday called in Christianity? (Hint: holy day)"
            strPossAnswer = ""
            strAnswer = "Sabbath"
            strTypeAnswer = "ShortAns"
            intPoints = "800"
            QuestionWindow_Form.ShowDialog()

            'Actiavtes Double Jeo Round
            intJeopardyGameUsage = 0
            blnDoubleJeo = True
            Call DoIntro()
        ElseIf intJeopardyGameUsage >= 49 And blnDoubleJeo = True Then
            Dim intMoreThanZero As Integer = 0
            For Each TeamScore In aintTeamScores
                If TeamScore > 0 Then intMoreThanZero += 1
            Next
            If intMoreThanZero > 0 Then
                MsgBox("It is time for Final Jeopardy! Good luck.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Religion Jeopardy")
                Gambling_Window.ShowDialog()
                FinalJeoWindow_Form.ShowDialog()
                WinnerWindow_Form.ShowDialog()
            Else
                MsgBox("Sorry, but you cannot enter the Final Jeopardy round due to the lack of positive points on all teams.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Religion Jeopardy")
                MsgBox("Due to this, prizes are not awarded to the winning team. ", MsgBoxStyle.Information)
                Dim intWinner, intWinnerOfPoints As Integer

                For i = 0 To intNumOfTeams - 1
                    For Each TeamScore In aintTeamScores
                        If aintTeamScores(i) = TeamScore Then
                            If intWinnerOfPoints < TeamScore Then
                                intWinnerOfPoints = TeamScore 'Finds highes points
                                intWinner = i
                            End If
                        End If
                    Next
                Next

                MsgBox("The Winner of " & intWinnerOfPoints & " is Team " & intWinner & "! Congratz!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Religion Jeopardy")
            End If
        End If
    End Sub

    Private Sub UpdateLeader() 'Needs to be in a separate sub because it cannot check for the leader in the beginning
        'Currently not working
        'Dim intNewLeader As Integer
        'intNewLeader = 0
        'For i = 0 To intNumOfTeams - 1
        'If i + 1 < intNumOfTeams - 1 Then
        'If aintTeamScores(i + 1) > aintTeamScores(i) Then intNewLeader = i
        'End If
        'Next
        'If Not intNewLeader = intLeadingTeam - 1 Then
        'If aintTeamScores(intNewLeader) = aintTeamScores(intLeadingTeam - 1) Then
        'LeadingTeam_Label.Visible = True
        'LeadingTeam_Label.Text = "Team " & intNewLeader + 1 & " and " & intLeadingTeam & " are currently in the lead!"
        'Else
        'intLeadingTeam = intNewLeader + 1
        'LeadingTeam_Label.Visible = True
        'LeadingTeam_Label.Text = "Team " & intLeadingTeam & " is currently in the lead!"
        'End If
        'Else
        'LeadingTeam_Label.Visible = False
        'End If
    End Sub


    Private Sub Adjust_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Adjust_Button.Click
        'Adjusts the Scores
    End Sub

    Private Sub FinalJeo_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalJeo_PictureBox.Click
        Dim intMoreThanZero As Integer = 0
        For Each TeamScore In aintTeamScores
            If TeamScore > 0 Then intMoreThanZero += 1
        Next
        If intMoreThanZero > 0 Then
            If intJeopardyGameUsage >= 49 And blnDoubleJeo = True Then
                MsgBox("It is time for Final Jeopardy! Good luck.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Religion Jeopardy")
                Gambling_Window.ShowDialog()
                FinalJeoWindow_Form.ShowDialog()
                WinnerWindow_Form.ShowDialog()
            Else
                If MsgBox("Are you sure you want to start Final Jeopardy without finishing the game? (Recommended: no)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Religion Jeopardy") = MsgBoxResult.Yes Then
                    MsgBox("It is time for Final Jeopardy! Good luck.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Religion Jeopardy")
                    Gambling_Window.ShowDialog()
                    FinalJeoWindow_Form.ShowDialog()
                    WinnerWindow_Form.ShowDialog()
                End If
            End If
        Else
            MsgBox("Sorry, but you cannot enter the Final Jeopardy round due to the lack of positive points on all teams.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Religion Jeopardy")
        End If
    End Sub

    Private Sub Exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button.Click
        'Exits the Game
        If MsgBox("Are you sure you want to quit? " & Environment.NewLine & "(It looked like you were having a good time :D)", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then End
    End Sub
End Class
