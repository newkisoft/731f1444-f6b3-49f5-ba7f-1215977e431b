using Xunit;
using System;
using _731f1444_f6b3_49f5_ba7f_1215977e431b.Services;
using System.Linq;

using System.Collections.Generic; // Include this line for IEnumerable<>

namespace _731f1444_f6b3_49f5_ba7f_1215977e431b.Tests;

public class LongestSequenceServiceTest
{
    [Theory]
    [InlineData("6 1 5 9 2", new[] { 1,5,9})]
    [InlineData("1", new[] { 1 })]
    [InlineData("", new int[0])]
    [InlineData("1 2 0 3", new[] { 1, 2 })]
    [InlineData("13499 30345 29165 5316 9961 4977 27681 12713 13049 14148 22496 23300 6746 23300 21043 24976 13169 25043 16072 13066 10895 9745 12429 28800 20256 25029 16510 14796 16677 30270 18106 21084 4836 22266 10717 820 13021 7110 14474 24117 12801 32295 16711 18079 14879 17913 23694 25301 18591 26966 7456 23392 370 25529 6813 2871 11849 2147 2642 1341 15877 21502 23122 4876 22639 385 712 4337 23082 26195 395 19255 19686 22963 13299 16553 12245 11095 748 28242 9315 27987 5448 2183 21282 5437 31834 17704 7427 14479 3776 6946 27852 26700 25984 6968 15558 28647 12119 17924 9398 31584 20045 824 1039 26800 29581 7722 7270 18535 11636 27536 12326 20884 7144 31879 31109 19685 16107 731 3511 15119 4975 19074 97 14960 29292 27753 23376 28659 26161 7796 15979 30517 27128 17600 15334 7654 18364 10283 17593 28273 2127 30230 14673 19935 10663 28009 29317 12536 3960 23768 22219 11436 25097 22117 20396 26034 20288 15398 13173 9071 25086 2633 30512 2585 25523 597 15570 16412 31785 7090 4534 701 932 23916 29002 28157 15149 1332 24585 31680 24363 8104 12969 32302 18483 30164 21909 6490 3617 29688 10397 33 24936 28043 17132 30806 3750 25217 13115 27164 24700 10698 4165 32402 21404 9499 28027 4534 20771 25072 2040 31619 25386 19410 16311 29789 6039 21461 12548 6319 1337 12646 560 20435 10005 8259 14729 6706 506 16331 12169 2732 18524 30584 29006 28474 28767 1194 10058 27857 28721 5542 21564 4746 5277 5598 95 10241 9693 3955 9441 15098 20144 17912 27542 12363 31149 28281 5870 23542 6359 10427 9765 25749 2929 7622 2489 30203 5652 26529 31777 1816 8446 9821 21180 14109 12461 26196 23304 1505 19629 15283 6164 27523 18606 14134 29752 4946 9177 6195 15107 15849 29284 24538 28533 3742 1380 10683 21102 18462 17635 28041 11623 15441 28723 3613 13664 29572 14465 22973 6681 20166 27053 24479 5509 10642 5466 16041 3964 16047 29761 20859 10672 21589 29130 23471 18402 29585 5597 7263 26710 12010 16629 27112 24708 15429 28279 15086 21008 26118 28995 16545 27644 6008 24200 30270 19485 2159 6876 18904 5323 19500 15756 16984 2781 18304 15920 18115 20437 21045 8323 27323 3159 1961 4722 25673 7904 2748 12403 3801 8884 16620 25624 8070 25368 18623 4324 28312 3778 12130 861 31307 16270 10639 22114 1747 10866 21427 17087 32668 2996 15697 3327 32214 9050 17313 1410 6193 21987 32638 20175 24549 17716 19071 24106 12022 30165 8035 27242 11190 21597 22962 15621 9611 12075 6305 6509 12018 30807 18742 11935 6340 25576 7086 18168 12985 13896 26652 10827 29994 22261 18002 26162 30747 31608 23812 28833 23416 32411 11307 22721 1183 14295 22184 31227 21791 26380 12074 25938 16063 2165 3153 29943 22723 9434 10260 15895 23146 29191 3680 21752 7867 22398 24321 5956 5505 11113 26310 28837 17813 15314 21472 19857 17499 30742 2444 12392 18063 20119 22258 7356 11842 4786 5452 19695 14879 32497 29002 26116 14835 10113 25525 7599 27757 28902 7508 1710 27170 24301 27148 30556 16851 20450 20298 16004 10739 30724 27046 6771 27492 12598 19904 9809 27010 29431 28782 12721 27490 1684 23066 13926 2651 19356 10597 24728 27078 8341 10512 23832 7171 17389 32029 25073 22717 16692 11057 9536 26734 16008 573 13893 26917 15952 9565 27833 20615 10541 15873 25186 20243 13357 6474 10982 30891 30530 13495 15837 22096 18419 32256 18217 17710 11346 19010 20874 18136 31278 18525 32621 9940 30345 29338 17925 6490 2380 17298 24221 14169 22842 12875 25133 31675 25635 14755 17195 9706 26458 28402 6563 9619 11369 27627 30090 29610 3586 4035 11088 31918 18745 23446 20148 46 28401 28166 20444 2444 2452 25125 28325 26113 19208 5525 30776 15329 22238 6637 734 10016 31948 21855 7189 32534 30557 5784 7395 10623 743 8168 6250 7878 24766 28067 6333 899 6823 15303 7666 31554 6799 3806 4984 6278 27261 17446 12203 3597 12486 27888 29094 1366 15488 31046 12632 15969 13880 30160 30171 23734 18664 24825 1536 1448 22307 23373 26415 13275 4243 14117 15982 25604 31653 11143 18367 32496 18307 11848 22447 9416 31299 14707 6956 15763 20317 32751 2455 29436 23139 21851 15642 30549 16876 19773 9532 15837 9938 21852 18354 2110 2973 20330 888 27994 20542 28134 2593 15687 5633 22593 876 26264 8125 23104 3863 16607 589 8865 6392 24688 14660 21761 13129 22375 29661 29437 27460 2028 11825 24728 19440 27573 27309 2012 826 29901 8130 24517 23879 27540 11742 23130 2569 28168 29084 32285 24848 29762 17976 11941 6051 32323 3141 26762 7440 20209 2210 29825 4416 22621 12202 21960 2446 15687 12459 30661 6105 3044 21913 24298 18392 5599 2820 24795 1710 2461 9288 10195 10431 12485 12292 1348 449 30720 28877 22461 17174 9213 20003 2065 5209 22457 20899 25014 6711 20477 1151 19051 24448 30760 16684 7453 21629 15406 19802 11276 22661 15329 20521 11818 459 17263 30874 7107 6010 11564 26691 15971 29188 4242 13896 30709 13750 25222 7814 1320 7057 27357 12561 16151 15445 13087 5601 8232 4574 21131 14536 4148 8883 15195 29095 15337 3037 27977 31970 31597 23797 12625 22545 3140 31361 17081 22265 8820 31361 2383 1210 5351 12100 18674 9545 10512 21632 27219 27425 16850 4770 16637 13622 30109 19555 29331 26923 20442 27292 25433 15812 16777 6747 19446 2462 1320 12598 23673 27166 31191 11231 4249 22183 14779 31481 6465 29712 28576 4650 32588 15445 12258 28018 25485 20108 22669 187 18 31515 15555 17841 20137 24617 8030 23507 30884 10834 16599 28362 29658 19871 1127 22266 28910 19125 28779 10328 32468 21580 3597 9083 1936 26851 27681 15605 2625 13490 18765 12003 13919 20449 10605 18627 19521 11511 23093 29062 26338 19349 11032 4070 4836 868 23657 19706 22229 31564 2497 25864 4274 8423 5024 31386 19625 13365 19543 8148 31011 15249 27685 2564 7170 29667 4256 9083 27943 4376 19286 28572 31288 25295 949 30002 14240 12629 12328 8967 8919 26324 10883 25266 23011 22727 9121 19888 19487 17841 31307 14518 26683 23311 31068 2374 27524 22411 16675 2433 13925 7538 24585 11836 18990 18792 24180 853 21525 8539 16875 12871 27003 28597 19322 22269 22896 7894 30040 5860 14200 10433 29639 11844 911 12053 15676 26576 4972 20288 24000 12924 8451 1775 6550 18830 8781 15560 8990 8952 20043 16732 26617 6117 29513 23639 14702 31634 608 14842 21516 5215 29758 19660 2705 11046 27434 30604 6155 9419 13890 4969 23869 23060 6663 9846 3396 8635 540 24152 3451 16578 75 9025 3227 13575 15561 22307 5415 3608 15291 5405 7943 18504 7160 1338 25714 24067 13073 6234 32274 862 10895 16496 2659 16370 635 30958 25693 23275 7460 13182 11602 19804 14364 31987 11801 11990 30340 28287 21356 20536 24713 16166 18831 30920 31791 2418 31538 31107 25422 6505 30617 2738 31449 22204 1018 10174 12134 8001 23591 23877 23275 9635 26220 15725 14278 10329 24251 28281 1281 5332 15622 1946 16339 27389 23277 12295 5738 29918 7321 13391 30695 9887 8424 1518 26027 15029 15562 22815 27089 24150 17899 21746 22267 560 28818 2462 13650 9050 17609 8472 200 8331 28350 32229 7329 28554 28265 15404 8241 18149 27247 18703 24807 4070 10822 1083 23946 13507 31642 8126 28355 7957 1776 12826 24796 31371 22410 11927 23239 4064 6794 14301 13922 19466 22874 193 11769 18357 13130 12128 780 25327 23163 30314 595 18725 22525 22721 2304 29006 23348 19267 28484 28262 6272 10467 31764 9246 31516 11519 17965 13266 11847 26606 9814 13755 16802 25048 7909 4710 27866 24522 23684 4196 13958 32521 13365 27204 595 6823 17044 190 19038 12117 4188 32049 2017 12664 24621 30800 3858 2431 2445 30999 25160 10867 1324 24581 16480 30415 3692 4741 29279 26515 32288 31405 7256 10644 17044 12074 5521 9494 6351 22395 3041 9116 27412 8286 30300 2047 30895 21640 6963 19646 10990 28057 11477 15509 15213 12623 16986 6481 3990 12026 12066 9442 28009 12592 32185 16562 28025 30657 4606 5941 20023 19949 13957 962 3187 20693 6457 11425 25888 31280 31558 869 9304 17215 6198 8059 26016 29699 2137 9988 10604 29357 8811 14816 25574 10070 8305 4875 26859 18416 3044 21549 22870 8317 13585 12140 30082 11135 14784 25477 30986 3759 24340 15899 25555 20465 17074 6223 21581 22152 10021 400 22261 3206 24450 3252 20255 13447 7751 29512 23794 18335 11145 805 25780 28561 17999 2628 6984 28994 13625 13524 15348 7021 19045 4489 19304 3479 24210 12342 3068 27462 1926 3742 1850 20334 3502 18312 20636 5164 25861 14353 26006 17078 11574 3910 20183 16275 32005 31730 26317 1799 31979 27829 26983 3538 5376 5718 12574 6682 12831 13402 17718 10405 26180 14294 7489 12875 26680 22657 15846 26027 13937 15373 4832 10526 24883 10168 10825 30953 16380 28702 13593 30135 5663 6993 28906 14150 27311 26923 24318 14176 6046 13795 27778 26893 21542 27359 28692 20487 15976 29129 8324 11374 10324 24037 26839 3773 11208 16290 15762 26621 18940 22127 22325 27192 6685 5327 30213 19761 19256 10928 4878 19282 32090 2553 8809 27366 13814 6498 19131 26504 29574 2440 13822 20443 9333 65 24452 11132 1341 3628 824 15669 10701 8845 4648 13684 13869 29016 20544 26875 2660 32652 32600 24536 26010 18882 15218 20632 17530 14598 27708 23480 32474 23013 28637 7004 26782 2503 25325 23363 31193 3712 10693 3323 16950 19489 7930 19537 11159 3348 2852 2060 20475 4200 18916 8923 26277 21097 16421 8331 3195 17268 1953 13181 27564 24841 29607 15960 1685 25890 21276 7675 10726 32707 5057 20406 18944 20179 10931 18361 20386 2090 26168 3020 6085 2539 3256 26177 10948 17684 27914 17703 28352 13907 17394 6593 22851 24860 6887 19511 25635 248 1049 6026 18858 25888 22450 25037 19443 10826 22108 25747 2967 18115 21764 14756 12682 7358 21982 8180 28735 1772 12970 3285 8211 4940 15413 23915 31464 24645 29474 15456 15120 20466 15850 4058 8558 1469 16418 938 9943 25135 14077 967 23742 28934 32529 15098 16657 32136 10078 27098 2398 16664 13708 10747 10554 24583 32628 29027 6115 10412 15842 27197 6436 18615 15513 29394 3449 27842 19352 22964 3444 32297 21916 10812 21599 29468 16358 7479 15907 25842 30526 477 23657 24768 20024 13059 26366 9771 4278 27793 2940 18554 28846 5429 24615 26096 12334 20569 32277 26968 11421 27731 1682 2529 12099 220 6082 32044 9996 20932 29832 4004 12168 18916 25511 5902 2359 8787 2599 29536 26372 2525 17659 4567 13583 24752 17888 9796 15535 23641 30600 3751 18872 10223 27896 5374 13561 21646 24623 863 30729 11783 1032 15941 11844 18390 11617 22824 10000 22101 6013 22864 28005 10287 18343 6890 26764 21526 21528 3164 31270 28345 4635 13270 15729 23792 28527 13097 19399 5690 31469 15837 10855 27498 24682 13693 17784 9629 23519 24630 7243 4463 26568 28065 737 19055 10953 15836 7341 23248 26775 7903 29850 865 31254 29709 22096 16319 4287 31754 19635 23240 18757 10445 27053 10068 20856 15862 15150 12576 9577 10593 4465 31243 10191 18939 31360 6021 6569 6356 5882 17476 13605 26742 11284 14904 28609 11894 5854 26818 10160 2888 1224 23329 16511 1111 5476 25389 29432 9301 18797 23623 21575 30160 25353 6800 22619 3079 6987 23129 21391 3579 20732 17371 16266 30665 5275 22312 18275 1590 13730 21602 24329 140 13579 29739 27107 21669 16659 1116 13491 14661 7742 15610 18112 19117 8603 24934 20020 21868 8265 467 11203 17273 30778 28925 24973 24447 5687 16921 26950 25208 7460 25351 13716 32637 4742 9935 25272 25052 13378 21579 23153 20844 23463 3361 28445 28957 4527 8437 12834 19411 14466 8412 2444 9077 28220 18195 18680 13888 3312 1777 20912 28258 27629 22810 32279 12228 17984 6134 23624 14375 27258 97 31738 17778 6067 10916 21415 30282 11214 4004 237 6372 1791 28250 26676 23575 18571 9603 30609 5814 18639 21913 4330 6428 29828 24321 24411 15624 27969 4230 7129 10156 4929 6662 1301 29184 23655 5995 3747 11100 7295 18397 2908 27206 8903 17719 22273 24457 20654 20407 17185 8071 3547 505 19260 5583 15729 294 21544 22258 6290 32105 31412 17555 4642 5794 13708 14270 10189 31071 20060 9595 17483 18440 30264 29090 5858 9305 31036 25584 1069 27925 21871 29531 5149 1017 14573 23459 317 12271 11078 12586 19770 28549 26145 26373 32418 20381 8485 31571 27628 6758 21785 15821 14265 29323 14921 25759 25177 11946 1580 25463 5265", new[] { 1710, 2461, 9288, 10195, 10431, 12485 })]
    [InlineData("2311 11333 14555 1947 30594 9799 9663 11887 16326 1916 855 1089 7108 24423 11050 9291 608 12201 9576 3788 26729 31009 4477 16209 3535 9303 31974 30771 11024 18715 7235 26465 4852 6505 6830 2143 7290 29584 29516 26511 26898 24467 2337 10928 23308 31696 28969 676 20561 7391 8868 27254 30033 9405 433 22427 17468 21802 30750 16248 1141 8527 4223 5669 24132 17060 18301 10865 22219 5393 1905 806 18491 32340 562 8590 10823 25762 23850 19765 16089 30865 25520 19697 30468 22069 13202 12576 9275 16777 6128 4913 18880 529 1617 28262 8798 8638 29168 30167 11867 4882 26967 3003 23977 644 12847 15843 10844 22310 22359 27527 14177 9861 23859 30789 18284 8145 4167 12391 8242 12862 8708 16997 11737 29353 2017 29098 31404 1151 20654 26267 20244 2523 25637 16342 3523 24302 24771 18615 8243 9380 3030 31009 1871 24196 2006 8827 25712 10201 17656 28152 3722 17423 24577 4124 1960 3679 25432 21884 26261 3247 7776 27845 2268 10675 1796 4607 8435 23129 22932 32531 29876 12900 27343 17803 24588 11350 24641 30106 28663 10388 17103 13916 10668 26565 8080 13150 21012 1147 10974 865 18817 12309 6573 27739 20381 14052 9500 10431 17313 3980 27722 4606 13511 31149 10347 21582 22273 28611 26395 4010 12267 28747 16113 2586 4094 25128 12888 22324 11271 6212 13466 6371 27352 14458 1342 15719 15166 2484 21908 24221 1587 27984 27790 9857 4436 1993 15569 23793 26005 23699 8460 692 3635 24902 12937 7610 17386 19455 28162 6821 22633 8451 6837 26505 30211 17318 10170 11248 1959 3692 29589 16930 23826 13933 12808 21923 24387 32254 25643 19196 26927 31373 5822 21694 6327 29133 23229 22981 11223 4628 11317 4282 15904 2561 15191 29915 31336 17249 19402 30719 5312 17747 7750 5588 8358 427 6239 11372 6012 4501 7838 15864 9017 9595 21718 32723 351 11304 14517 23234 4653 29997 19098 16506 26645 21123 14502 31330 27504 32115 16406 21915 26225 17075 14544 20542 3415 14802 32571 11236 22247 3029 12372 2412 14618 3363 27647 29176 7699 11934 4506 28985 9555 2579 10968 9453 1328 3540 30925 26021 8323 2979 22341 27852 9378 11986 27226 7141 17294 7593 19014 18708 24173 18952 8565 13536 13370 13645 28895 3383 26811 11128 28308 8626 30643 14734 12952 11547 26714 25403 9714 22573 21770 23482 26624 22938 6971 17914 7693 22355 18353 16377 24869 27907 4852 15732 15912 31708 513 30147 31774 10135 32575 26879 7370 9398 32692 16485 19330 15373 2169 3583 11838 10112 10347 12161 19694 11278 14884 22641 785 5391 554 1930 12163 29881 32101 27491 5782 19945 29655 31308 10853 2849 9095 16760 11621 26316 6078 12130 25405 10442 118 23913 17368 23848 7696 7357 25784 26671 5445 19071 3213 7073 16223 12068 9478 12607 19113 27931 32487 20110 16164 17071 7260 30171 15227 9006 30092 2173 32313 27467 27506 15962 3898 13505 23784 13997 7519 3385 4613 1542 25734 5230 29097 26002 12218 17807 13654 26524 19366 28645 3906 21844 32080 8885 30378 6607 20740 4200 3688 24144 21901 11497 22984 15302 6060 2895 13208 9621 29122 16060 15230 29081 976 17028 11663 8552 26529 11666 22556 20696 30022 13576 9167 28098 11203 16934 25079 7429 4616 8045 21793 28877 9251 260 10216 21525 8371 27738 17934 20330 19104 17165 19403 2802 29449 29963 32612 12718 24446 7671 2304 6652 24688 4558 23736 22368 11237 7370 2797 6531 20592 31366 27358 31868 21601 18532 21369 11855 21817 30508 22130 3507 15201 32757 12691 9753 22043 24649 27219 11497 29624 8580 18345 25615 18956 28541 7714 1462 17183 616 8754 7507 549 24571 13511 29158 13488 14288 24100 25981 1061 24331 27373 28153 15212 12092 24446 2836 29932 19591 13697 23971 25783 5890 6080 17433 4865 19294 4151 8269 6871 5834 23662 10877 16654 8724 23558 30098 30585 22545 19857 2213 8287 27456 19879 12739 9771 24234 19510 30189 15206 5644 27673 16995 22243 12600 236 17187 16441 14009 7967 684 16502 20918 29258 14087 19218 10009 19904 24584 13090 1519 11111 6866 16590 30482 3271 20121 15109 28678 29280 5804 14704 11554 23873 3506 21156 30448 3798 24115 31387 22230 31490 15451 9573 32501 8301 11515 539 26961 15136 15825 25109 29234 1359 4873 8284 29131 31349 28163 7522 6426 20647 4439 8945 5647 7201 9751 17506 17136 20774 1620 3855 25852 6151 4323 7947 15951 10113 27232 27664 30469 6475 20340 25272 8610 27888 23636 7664 24242 11483 28042 21674 25516 27056 32248 20435 26908 32739 9754 31877 17409 23427 8331 28285 11892 11862 30667 26319 907 19499 16703 13016 29309 8556 2425 30581 27911 30707 21946 15474 21774 32286 24245 19526 11653 17446 26774 15357 21137 9132 23619 12149 31979 17813 1506 11725 5255 14872 7323 6683 5747 22293 30623 9309 4609 20649 5225 18099 296 16383 21060 8907 40 3177 1805 21404 10349 27311 20794 1879 4790 26279 19227 30106 17526 11013 864 1511 3194 31605 24284 14934 4813 5351 18312 12934 8153 26666 19659 23257 24270 25277 6392 7137 8008 14818 24601 7701 23084 27635 11243 30153 32210 27641 10537 19293 17770 11131 23053 21428 8088 30356 21013 11495 26722 22088 24323 29499 31308 27928 17191 8785 23233 468 25824 5789 1461 11441 5985 17177 7305 23196 24753 28475 31791 6861 24821 4388 32398 27294 16114 6170 27432 29598 15822 15160 23290 28641 24598 8292 5027 10395 15366 28546 7625 17133 25860 9703 6841 20223 3693 15889 7501 19791 19348 32661 2579 7753 4360 2904 17067 4119 23318 30722 8305 32442 7567 4784 605 14938 24780 6122 29223 10202 12270 30932 9390 20400 15466 168 22938 20212 23238 28259 24128 24246 15517 22207 14279 26005 3049 25186 14473 18317 19330 15445 1212 26641 8417 17591 19026 4698 27434 23475 12317 15358 19306 22703 16439 21956 540 454 20897 7863 17907 6009 13610 11641 30675 18593 10643 9178 22560 8872 23280 16553 8508 20985 29009 17355 11083 18101 29346 22665 32058 4520 31696 31278 28415 3451 5422 1746 16674 10283 9750 29809 19836 24762 19411 23616 13631 19748 6078 20544 12342 15508 30888 12051 24910 18904 21368 27151 21590 29202 3861 29073 2307 945 6023 15251 12087 31136 7257 6273 30850 5821 3649 19017 8938 21901 8195 4530 8423 46 20114 9710 690 1165 13432 19058 1215 22745 11385 30469 26504 1079 1907 17943 29837 8119 22921 7509 21657 25478 8832 17530 6982 5222 21865 24168 11203 25948 897 30839 23253 8616 11861 9229 29212 13050 1322 20079 30872 22499 4507 19158 25708 7818 6020 17094 6625 30624 11295 155 23469 30102 18541 18533 4214 3085 23256 13045 402 25486 7190 16184 30481 5499 11088 3524 21757 25669 13700 31409 7648 17376 11304 2474 32391 18036 20240 22595 18182 16726 3473 2701 29948 15926 743 26089 13080 3226 4564 3609 29148 1931 25482 6301 32161 25485 19915 27196 13788 6357 25679 4833 18847 15799 14694 7080 7523 25950 4574 31545 15876 22207 4135 9301 1293 12239 6837 25262 21046 18676 422 31228 32299 27834 10149 15181 27279 14280 12814 1180 21313 13586 1106 24230 17630 2640 2718 11513 23687 18606 6071 9294 13540 13765 23081 31512 9320 8394 11424 2141 12503 6149 17814 17605 23558 4741 2606 25073 11747 25107 2144 27661 8116 356 23639 10665 19620 4755 1303 11716 2939 8654 27747 20522 21933 79 9694 1 8086 19341 10608 9374 1540 29876 3307 157 29942 23635 239 19248 11171 22101 5387 29623 16830 10803 1828 17297 4601 25448 8731 21042 11720 1572 28586 32630 15975 31812 16783 26677 30494 20098 21997 2328 31940 32233 6895 939 26242 4493 21934 14771 15321 11384 12373 12993 5094 16359 29571 7 14821 11703 28400 4715 31477 28442 21844 14042 282 5006 3972 11487 24456 11280 19166 2932 13343 30348 18152 26648 562 23961 9780 29729 10892 8291 18055 1108 9397 14056 25657 14003 23921 18024 3295 10902 24202 14870 9512 32509 9167 21524 1541 2853 16733 19102 29965 1369 16157 17798 31775 3083 19854 20448 25673 17699 14277 4606 22504 1943 14002 26527 28689 17212 2468 9827 12592 6876 30735 10370 15087 25736 8334 28606 12122 1071 14628 29846 5440 21616 9415 30141 14812 4525 543 23498 21940 31585 6027 1329 30914 8115 16485 3698 466 1355 16263 27280 9515 10084 6925 24517 18033 30754 25949 15476 10698 23846 5989 22623 16448 23137 24612 13850 4967 24357 3436 22720 5183 27010 29158 8676 20827 29647 27734 19402 22595 24711 29728 21463 17944 22615 20236 26951 19318 20084 21574 13342 10142 7986 24745 2145 24277 31955 24636 22917 12295 7836 4349 552 3504 26159 25310 13311 7677 28436 6414 9232 1582 15513 4217 18209 1342 31196 20370 12912 8646 38 17232 29860 28447 6010 19830 31492 11718 9582 2072 22247 19205 15930 25179 30571 976 19471 31356 11114 12014 16554 22804 32682 29273 1320 29082 19796 26598 7196 3113 3240 29992 10719 31875 16366 23186 22311 19031 2736 15837 16859 11967 18726 13225 28710 2829 15346 3175 31179 15559 7182 26742 23480 29424 11010 22412 10717 26761 4954 1880 4926 10328 11607 17766 27719 15848 31717 22594 13152 30673 30157 29664 17346 7993 28460 19771 10889 18587 14116 4413 21002 8648 15825 17119 30566 24875 22142 17553 7776 14928 27161 4316 30571 31656 11749 26182 27655 14726 12911 27254 17742 10862 24259 2200 8394 6287 11231 3843 10122 3214 13416 20505 15221 5509 27804 19055 3806 21068 5768 7215 23128 8183 18043 17850 9419 4511 3002 32657 20935 5478 4469 10101 27161 27317 19450 2253 21148 19912 1577 1097 25938 31853 25384 23237 8371 30728 10328 8048 24901 10459 25479 5421 22893 18052 16743 31545 15237 10695 10302 3342 18990 27534 27360 14728 17128 29998 10203 21831 22240 26092 10481 19540 9736 29120 22219 5895 28781 7513 5355 30248 29126 31584 6627 14932 6984 20225 6084 6818 8130 14248 18650 24199 1509 18952 13462 24311 13539 14946 16588 8909 12093 31748 25375 6765 28629 31248 1721 16040 7499 19838 31295 5856 1926 5220 31235 27244 9105 20085 10876 8509 31145 25288 5876 6082 14740 13020 2177 27146 26932 24280 18742 31273 24923 7959 10138 13788 3297 22243 20057 24432 7668 17537 17466 24031 11696 29295 10321 22589 31215 19945 32374 8274 13667 1713 8182 12425 7650 7184 9352 16649 19712 15128 22402 14369 30435 21037 3404 31209 2899 32196 27925 23334 27921 12905 710 15215 13162 18439 11572 2702 10763 19044 15514 15657 791 13035 21830 29858 28535 28590 27282 24123 4466 23467 26134 3454 32125 3150 20252 21980 15700 6200 1620 26516 2377 15167 27082 13270 11228 31670 29972 23592 17293 13550 12752 12554 22254 11004 3150 981 28412 3005 24713 20457 11183 280 21340 32519 1744 14467 19442 19708 14603 969 8575 3712 30021 30474 20781 24413 28208 10243 20570 31700 23068 29327 20224 18748 26896 26222 32372 20972 24857 16966 12372 14427 21730 8167 25018 25990 10373 13779 1718 30354 22689 20990 10748 11699 14253 29138 13529 27212 5515 7030 29548 27736 1376 23632 10514 26376 13732 4297 18722 9901 3701 22864 10203 19929 2609 24737 14234 28097 31811 22343 9808 32230 14909 18527 28468 30453 23336 11168 13493 5355 279 22680 30387 1148 24835 16184 30958 32694 31954 2451 28095 7650 17337 2787 14598 23211 3268 8141 24419 6274 8115 25574 30121 8768 16392 24693 9359 28685 28254 6267 5289 13185 21500 5616 22167 28426 3242 23632 7037 7310 17092 25686 20915 10065 20876 1287 31165 15640 25028 28147 18301 14991 13437 5816 25511 14056 4138 18375 24950 29381 1016 8299 15517 11864 30050 15879 29569 10952 11263 26783 4517 23255 20383 26777 15973 1731 3223 27077 9192 26473 21081 3996 16976 31920 24648 7877 819 8997 5322 24542 8527 11491 12958 8056 14457 438 4208 28515 4567 2688 26282 3373 79 27611 12174 4581 24895 21503 19842 20260 5487 24551 27562 32079 1604 23471 19644 7958 2870 25153 31760 15936 17283 8240 5367 26027 14373 15844 5198 31886 23042 13560 26707 26370 12388 5344 12983 4033 19368 31439 28916 16173 20538 16599 32480 25492 11713 10323 10114 11954 22166 898 14373 11383 2939 8820 18860 14091 3978 1834 13349 27664 22635 9465 24737 1831 3786 12079 27970 17845 29448 15097 22421 14311 31281 14468 8482 8947 14127 1891 8770 22689 25661 10801 32561 10251 8350 23927 29540 19360 13966 5583 26397 30831 32121 10570 828 29347 11371 10256 14168 19273 12488 10310 26126 11098 23869 2357 11161 20469 1270 29096 29347 7148 22289 3477 19291 25218 3667 20224 14536 20339 18714 13853 26717 4149 7571 25781 1997 8830 15917 202 11553 27654 16974 10878 1287 32654 26436 2353 15213 13089 23934 13290 21070 27546 30204 30968 23244 16742 17412 18649 17536 25227 1815 18522 14094 21993 28963 19968 10748 960 7418 20135 11972 10099 18691 32105 8487 3724 10799 8897 12741 18687 27439 28400 32491 11955 11237 19360 12204 24126 5400 28872 17715 6385 21611 16591 5719 8212 5264 12276 10608 30578 17849 15085 24681 12569 19023 12494 11031 9819 23527 21549 13257 16920 15474 6020 14881 16448 1971 30934 4130 1683 14583 16534 28041 31403 14592 10180 3425 31037 2114 10585 18898 21148 22866 741 10810 28798 12187 10359 6015 2307 22099 12221 10915 755 17325 30316 18840 28487 15440 2018 1622 15340 19209 1547 29740 963 24764 6529 26451 8172 12449 11511 21193 24132 7340 30679 14428 300 17997 7210 24325 27789 5978 23481 17272 9241 22346 10353 30457 32467 8355 5132 24689 13265 19125 25326 5057 9280 7049 17997 13142 1706 22037 405 4094 22388 30897 32523 31482 12971 16335 6064 32340 31488 16614 4712 28531 29200 12719 7771 4076 9705 12180 19612 12443 22474 7014 19721 2803 16427 23886 29298 17554 21501 9478 16893 20760 28467 31304 4552 9786 2177 12679 31441 30226 21092 6366 8723 25529 28002 28998 7410 26136 3987 2059 29913 19707 17760 1153 3618 7271 12171 15859 30262 12846 25200 11740 23797 27072 19082 21081 15704 12868 14904 5343 31060 19176 1217 2345 27906 6517 19094 6261 15614 20262 23256 27888 25613 20410 19994 12655 17410 3784 15976 31071 15842 22355 16520 25855 5446 12702 639 21965 8961 23361 13144 18237 6915 1405 6176 8113 27005 19917 29237 3494 27462 9405 6849 17707 1406 5887 30593 12696 24689 11452 11467 28540 18877 21288 12495 8919 440 1113 9245 32138 30732 8537 4967 2571 15268 12922 1672 3677 8652 489 198 6976 26771 17542 22100 7077 22644 17651 31515 30820 10550 17643 11963 9265 11793 2262 10700 9165 3346 16794 12393 26233 1473 18611 11759 688 2816 25222 15874 11029 13366 31474 18129 28587 18861 4137 2203 8004 28729 16318 18035 23868 14363 10751 27712 16230 4900 8068 22023 2119 30238 19720 7277 20866 10599 22904 2679 14996 3295 10826 8341 28609 21252 16912 18655 7502 30556 27981 8350 8945 29716 12679 31502 7046 31462 12957 354 3331 13632 603 5129 21678 20386 3660 20784 9102 21575 8143 25736 7967 6409 8813 1097 31306 17535 9322 16247 6803 11880 17818 356 7573 8012 2166 28278 21163 13152 14703 32298 31985 25771 24707 30297 29035 103 28941 11194 25987 2986 11233 11177 441 23365 26520 13094 3222 25324 13097 5921 16865 32664 1722 501 10774 16682 30389 10802 1556 30545 7453 26271 8982 1453 11555 17279 10980 17205 25844 32020 17483 26838 20950 866 6090 21340 6771 27445 3214 7318 17268 28773 20897 20405 8786 27993 1886 15606 29289 27594 7464 12417 16463 13001 14171 4240 8035 30212 12675 9939 23977 2629 4300 6420 10709 17211 31418 21783 24485 24189 1050 29636 28276 8140 27705 22407 3597 664 6227 2552 13757 9414 25422 7351 2476 20145 5544 4506 12908 15471 6575 3595 21203 3157 16368 23979 4102 30397 10225 2108 24535 13062 8483 32445 4433 11741 6162 9174 17296 29883 25567 13175 16087 31407 2032 19901 25564 6750 15846 10517 9574 31048 23503 12195 16410 12365 27293 3045 9362 23919 216 26771 18352 729 13711 26570 19762 22305 16276 5482 16518 27338 5353 22717 20447 18189 7797 10585 15752 27096 21499 2887 31609 17176 21581 5732 9512 5940 19901 3336 19361 27353 19157 17894 18393 23549 14152 27955 1855 3102 12583 24843 1685 32715 31320 11536 28414 5990 7749 26964 2392 1320 8145 121 31691 25701 17296 8470 1442 22034 18999 24157 11610 18052 12113 17403 5369 16506 16436 24896 26786 29022 7988 3968 7013 17096 1814 30649 26203 11588 25288 7029 15859 10325 3407 25842 12679 23482 19968 641 26931 30191 25843 4396 13798 19447 15285 23195 26553 9817 3645 10809 24192 24425 8225 32146 2207 14024 21002 5119 17440 32302 11110 8582 22018 871 11356 10492 27603 23452 31749 16748 23425 29652 18137 19133 5485 2746 24935 21902 31937 30625 842 16997 6660 25285 11864 23561 23531 21204 5660 28972 23154 13229 7047 12621 20524 14951 12514 20701 15831 19093 14855 14497 27700 16584 15569 17495 16406 18006 30161 21660 5304 4698 9538 14349 4179 15356 10303 12205 9968 499 12852 4743 16251 11080 14995 21652 12058 25948 29384 29918 32445 17196 22638 5862 12021 16852 14275 19267 28169 30290 12889 19341 29767 18573 7695 11641 31384 24470 20544 20805 32599 9005 10554 3927 19811 30343 29682 26913 31091 4174 28150 16711 18858 5098 2978 24324 15212 20479 19607 16586 7023 17974 13417 552 25621 24641 15256 22769 22009 30233 19650 28059 32455 2442 8726 4837 8786 23282 5900 8380 14816 15174 16979 30304 32200 16213 27659 26563 11584 14417 13365 6706 2160 5515 32104 5174 12491 4990 28613 1213 25502 23567 10285 1397 17129 31763 26545 23673 8303 21010 22345 303 32521 23114 13257 26736 15935 31735 30226 23530 9241 15314 19333 24771 14643 30680 29374 29055 11024 4172 20606 3876 10416 8703 20712 28060 28005 13775 26865 16218 28130 2414 19474 25665 23445 21861 10815 32705 29239 13400 2589 14915 17313 3979 4976 12743 30177 13477 24018 24011 10125 30900 6059 27247 28247 3186 6493 20184 9186 26055 14527 8914 29908 25230 28877 30649 26157 2204 12702 14489 17623 1790 27798 21908 13181 23683 12508 16004 19105 18299 27662 28898 32489 25277 9012 7399 16826 5103 14323 9712 4104 12033 3588 551 25453 29435 9444 15712 14712 17401 31180 9025 9543 18035 17891 21670 8024 16322 27827 19523 1948 24544 11993 5772 3533 22640 29953 16593 29698 25854 18194 17326 24449 10375 17318 27810 11220 1084 11197 2814 29727 19331 22194 25601 18096 31039 8814 12865 14040 19025 13275 13388 16633 24927 7067 3728 13537 22483 13051 1144 6742 24615 17698 19672 17394 23905 22671 1419 1074 5081 11458 2651 14537 22338 16440 13088 8250 23016 29341 15660 11685 311 5950 25575 20193 25469 3005 27831 22732 21233 9992 10787 3551 6643 5259 14903 29446 19605 28581 1066 26286 21339 13145 14654 11807 4927 21063 23784 27916 22264 2778 6193 15208 23932 19394 23644 19836 12740 15525 6345 25143 12239 16145 2073 27589 23273 31670 22675 9827 26925 20434 13254 4465 10313 12012 26992 32456 8065 19653 16799 11343 4855 9100 14870 7113 19497 10833 13042 7409 19387 20412 20110 15817 18551 3327 2211 5423 8082 9481 18612 7089 6704 25596 29609 1698 11307 29410 16570 22893 4112 5020 21902 8490 25707 22810 28068 3695 11845 12242 4339 24937 25834 19050 7629 23595 27376 18104 10761 12101 6260 7917 32609 5273 15015 15117 14105 3178 11402 13987 14562 28854 27893 11954 8445 21190 21982 11246 20899 22275 22744 32044 13221 779 25818 5656 27216 12804 22850 17958 32403 9009 10777 23499 17764 22210 6553 2028 1375 11505 10988 5527 8112 31562 12855 18929 16436 3146 9687 111 22747 15660 5355 22345 27729 11776 26386 44 27613 14333 18806 2352 11401 7704 27913 12809 14211 11222 31246 8577 31171 13918 23772 3878 5870 13266 20446 13631 25466 23775 18143 7941 18964 3219 8068 10000 8254 21103 15130 14864 11837 27326 26002 12733 28210 4389 11722 23569 18055 24954 4879 692 17292 15065 11231 1720 5218 22773 10739 25734 20249 6061 24445 13336 16405 5344 10670 31081 18614 9345 25723 22826 4408 19182 19361 1463 4567 12669 27878 30793 14135 18776 4002 19053 9732 4236 13695 17333 25045 11612 6269 28589 23383 21467 19001 20496 10663 10682 22638 32572 29439 7262 6844 22244 18581 23861 3496 28421 31168 30795 24293 2331 8797 14616 3794 15252 30833 20893 19267 29061 7440 30639 26500 4764 29821 27794 5531 26454 18834 8905 17614 3441 16482 30253 18789 4261 23582 10813 12721 31631 7221 8885 27725 29934 29887 2658 9124 15633 9756 23604 29363 8080 14296 661 22289 11579 6866 249 1068 21072 13982 23478 31701 7409 26151 12823 4095 18388 10137 16043 12739 23869 894 12771 12712 1577 28455 6876 21794 22988 11853 21114 25944 16702 30712 7350 6954 17266 25248 29753 3187 19815 23442 13353 32395 19106 11670 5187 16913 8667 23247 11050 31719 27127 19938 27390 32637 27446 9819 19505 7763 16558 9292 6806 4281 11768 30518 6331 23514 32041 29741 28025 22776 30979 30520 4041 16889 22381 29687 9433 26403 10273 31112 1120 29220 7077 11690 22318 23125 13948 803 1031 28223 17565 12128 24241 5727 8484 9052 19788 13606 9800 3011 22498 18500 22925 7254 22079 12070 10298 10897 12291 15037 18446 23435 25333 27266 4143 26911 17306 31415 24163 16969 11271 10223 23682 2770 3315 19408 14892 15920 5392 14104 11959 31144 25244 27870 22379 12725 29490 8987 17906 22189 17895 11368 21258 11426 25490 12041 2429 23174 16747 19755 15699 29843 12760 8810 9030 1514 22403 14998 31862 23931 20144 26039 10846 8740 206 3406 16135 29213 22091 28382 23931 4499 15021 24491 32381 27795 9951 32194 28023 28714 9672 29241 4532 32459 1826 10424 22479 1008 13450 8249 20332 27396 23763 14603 20773 32129 27040 9245 16584 27734 29490 22393 16319 2187 9854 11279 25551 28455 20867 2228 17926 11346 2522 15978 32238 6583 8591 31202 23815 31788 24111 28223 32372 9365 9762 7453 32501 6149 6203 24530 28949 807 16782 5619 24997 31965 25986 7451 104 23590 3111 30183 16656 9541 19145 14917 2153 21024 31429 18671 14805 31206 21147 18994 14584 7156 5445 29172 13236 4602 19399 8949 18520 27993 15624 22357 23572 17360 6112 29271 13745 12120 882 24420 12414 1356 2492 8787 7054 2253 4204 15591 6432 7269 21493 3481 4703 14058 6371 2968 4940 8102 1899 1039 8952 13748 25927 15526 27638 18093 8641 8011 18704 14469 26637 21298 2617 2735 11227 26394 1475 29320 25645 28883 18898 5874 26726 17917 529 12095 9124 12818 26019 2386 4688 19879 16733 15104 15860 23278 29234 700 11084 19328 25582 7028 28319 21337 26664 1974 23119 11556 31089 6167 31664 29626 16082 12501 23062 13541 25462 4795 11314 8553 5795 11077 30622 32325 18415 12293 20150 15158 29616 2373 8362 21117 5044 20462 20433 21986 2098 25257 576 19705 3329 22083 24732 18596 3848 17750 14124 20441 30198 17190 11570 2469 13875 30153 1660 18545 16150 7051 9014 23173 6488 32656 12802 17354 18888 8635 18507 17620 19521 5583 21717 21279 15065 24020 8345 26265 30044 17341 20945 16481 23801 30279 9551 3791 30778 27940 21010 4788 4922 22617 19227 10723 12306 7909 21373 25328 23444 12451 6324 32311 14908 12145 18231 32 24931 13202 19793 14498 20662 12113 16428 25606 8167 13799 5935 18670 13474 10655 12681 30613 5315 5432 23054 3672 10438 13451 15683 10102 638 28782 1460 21524 31754 20951 4750 18564 17158 12357 31849 7622 9214 8027 23654 19535 10792 24526 2426 17418 26450 22402 16393 17821 30745 21744 26551 24813 6236 8651 27515 15588 23536 10467 22517 3186 24469 13129 13313 21713 1577 180 18316 26894 5660 16163 17574 16069 19236 9668 1753 44 12338 14101 23737 32594 21924 28233 4029 28329 14268 23533 7757 707 26961 30155 23580 24921 22212 7695 27832 401 13622 9640 19552 24960 29176 19953 23317 13550 13891 3473 7667 29018 21290 7328 10946 23358 10700 3083 29129 30869 25550 27705 23010 3225 4105 18158 25300 209 30591 28784 16860 24395 16020 29673 11405 16935 9851 7949 17883 23637 750 28924 24946 32670 14370 28778 4428 17385 21754 11517 12674 13239 7547 28662 26210 8689 6528 24596 16579 3299 31662 7349 31893 12936 29867 5183 3516 14856 18059 6590 28447 5759 11403 32207 26619 1792 27394 11964 15230 22490 7060 9192 30353 18713 2473 6254 20469 15952 13085 22789 20113 7062 16698 10535 10762 29647 3555 882 6549 27693 2321 14670 1289 30966 4740 13776 19513 22407 7090 26590 6272 27033 9732 6036 27805 21955 28993 10983 26305 4416 28234 7560 26855 14067 18953 12299 7012 20392 9380 4681 32191 28573 18678 3331 31170 19777 30783 28360 11473 13627 7706 16408 23419 32686 176 713 17231 27323 16684 170 16113 32328 16495 28007 28781 23808 15364 24492 26058 9883 14166 25997 27619 20320 1312 14374 882 4328 1318 21118 11374 22564 27171 28594 31639 21666 7170 13391 11855 3339 2640 1791 12459 7409 754 23656 18890 32711 24851 31313 25189 3377 10337 30214 6568 2687 24697 29182 7232 30067", new[] { 10298, 10897, 12291, 15037, 18446, 23435, 25333, 27266 })]
    [InlineData("923 11613 30483 19569 24201 13461 1189 30793 8848 16914 16053 21700 22116 3852 20909 5231 31469 3862 16353 22813 28735 4421 3618 32303 9932 31892 7823 22547 28888 11143 11695 3339 2094 11023 9661 27440 7186 24750 15427 24502 31606 23515 3563 29553 12145 22184 11409 28824 6636 10658 21404 5578 27807 14073 13967 31310 3132 4321 7643 1951 13289 24375 17912 11304", new[] { 3862, 16353, 22813, 28735 })]
    public void GetLongestList_ReturnsLongestIncreasingSubsequence(string input, int[] expected)
    {
        // Arrange
        var service = new LongestSequenceService();

        // Act
        List<int> result = service.GetLongestList(input).ToList();

        // Assert
        Assert.Equal(expected, result.ToArray());
    }
}